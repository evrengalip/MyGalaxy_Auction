using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class PaymentHistoryConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4908), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4935), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4938), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4943), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4952), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4955), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4962), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4968), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4973), new DateTime(2024, 8, 18, 0, 49, 4, 551, DateTimeKind.Local).AddTicks(4973) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "PaymentHistories");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8878), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8882), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8890), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8901), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8904), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8908), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8911), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8915), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8956), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8960), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8964), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8968), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8985), new DateTime(2024, 8, 17, 22, 34, 58, 656, DateTimeKind.Local).AddTicks(8984) });
        }
    }
}
