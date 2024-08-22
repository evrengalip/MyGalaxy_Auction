using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Enums;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ApiResponse _response;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private string secretKey;

        public UserService(RoleManager<IdentityRole> roleManager,UserManager<ApplicationUser> userManager,ApiResponse response,IMapper mapper,IConfiguration _configuration,ApplicationDbContext context)
        {
            _userManager = userManager;
            _response = response;
            _mapper = mapper;
            _context = context;
            _roleManager = roleManager;
            secretKey = _configuration.GetValue<string>("SecretKey:jwtKey");


        }

        public async Task<ApiResponse> Login(LoginRequestDTO model)
        { 
            ApplicationUser userfromDb = _context.ApplicationUsers.FirstOrDefault(u=>u.UserName.ToLower() == model.UserName.ToLower());
            if (userfromDb != null)
            {
                bool isValid = await _userManager.CheckPasswordAsync(userfromDb,model.Password);
                if (!isValid)
                {
                    _response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    _response.ErrorMessages.Add("Your entry informaiton is not correct");
                    _response.isSuccess = false;
                    return _response;
                }
                var role = await _userManager.GetRolesAsync(userfromDb);
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                byte[] key = Encoding.ASCII.GetBytes(secretKey);

                SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, userfromDb.Id),
                        new Claim(ClaimTypes.Email, userfromDb.Email),
                        new Claim(ClaimTypes.Role, role.FirstOrDefault()),
                        new Claim("fullName", userfromDb.FullName)

                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
                };

                SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

                LoginResponseModel _model = new LoginResponseModel()
                {
                    Email = userfromDb.Email,
                    Token = tokenHandler.WriteToken(token),
                };
                _response.Result = _model;
                _response.isSuccess = true;
                _response.StatusCode = System.Net.HttpStatusCode.OK;
                return _response;
            }
            _response.isSuccess = false;
            _response.ErrorMessages.Add("User not found");
            return _response;
        }



        public async Task<ApiResponse> Register(RegisterRequestDTO model)
        {
            var userFromdDb = _context.ApplicationUsers.FirstOrDefault(x => x.UserName.ToLower() == model.UserName.ToLower());
            if (userFromdDb != null)
            {
                _response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _response.isSuccess = false;
                _response.ErrorMessages.Add("Username already exist");
                return _response;
            }

            ApplicationUser newUser = new ApplicationUser()
            {
                FullName = model.FullName,
                UserName = model.UserName,
                NormalizedEmail = model.UserName.ToUpper(),
                Email = model.UserName,

                // mapleme olmadan böyle tek tek eşitliyorduk
            };
            //var newUser = _mapper.Map<ApplicationUser>(model);
            var result = await _userManager.CreateAsync(newUser, model.Password);
            if (result.Succeeded)
            {
                var isTrue = _roleManager.RoleExistsAsync(UserType.Administrator.ToString()).GetAwaiter().GetResult();
                if (!isTrue) 
                {
                    await _roleManager.CreateAsync(new IdentityRole(UserType.Administrator.ToString()));
                    await _roleManager.CreateAsync(new IdentityRole(UserType.Seller.ToString()));
                    await _roleManager.CreateAsync(new IdentityRole(UserType.NormalUser.ToString()));
                }
                if (model.UserType.ToString().ToLower() == UserType.Administrator.ToString().ToLower())
                {
                    await _userManager.AddToRoleAsync(newUser, UserType.Administrator.ToString());
                }
                else if (model.UserType.ToString().ToLower() == UserType.Seller.ToString().ToLower())
                {
                    await _userManager.AddToRoleAsync(newUser, UserType.Seller.ToString());
                }
                else
                {
                    await _userManager.AddToRoleAsync(newUser, UserType.NormalUser.ToString());
                }
                _response.StatusCode = System.Net.HttpStatusCode.Created;
                _response.isSuccess = true;
                return _response;

            }
            foreach (var error in result.Errors)
            {
                _response.ErrorMessages.Add(error.ToString());
            }
            return _response;

        }

        
    }
}
