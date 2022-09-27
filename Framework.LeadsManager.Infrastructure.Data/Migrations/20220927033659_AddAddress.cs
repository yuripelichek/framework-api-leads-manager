using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Framework.LeadsManager.Infrastructure.Data.Migrations
{
    public partial class AddAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ClientId", "Complement", "CreatedAt", "ModifiedAt", "Neighborhood", "Number", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { -1, "City01", -6, "", new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4786), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4790), "Bairro01", "001", "", "", "" },
                    { -2, "City01", -2, "", new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4794), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4795), "Bairro01", "001", "", "", "" },
                    { -3, "City01", -3, "", new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4797), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4798), "Bairro01", "001", "", "", "" },
                    { -4, "City01", -4, "", new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4799), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4800), "Bairro01", "001", "", "", "" },
                    { -5, "City01", -5, "", new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4802), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4803), "Bairro01", "001", "", "", "" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2992), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2987), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2972), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 553, DateTimeKind.Local).AddTicks(2338), new DateTime(2022, 9, 27, 0, 36, 58, 554, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(45), new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(43), new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(32), new DateTime(2022, 9, 27, 0, 36, 58, 555, DateTimeKind.Local).AddTicks(38) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8505), new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8502), new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8499), new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8485), new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 952, DateTimeKind.Local).AddTicks(8334), new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6857), new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6851), new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6842), new DateTime(2022, 9, 27, 0, 36, 25, 953, DateTimeKind.Local).AddTicks(6848) });
        }
    }
}
