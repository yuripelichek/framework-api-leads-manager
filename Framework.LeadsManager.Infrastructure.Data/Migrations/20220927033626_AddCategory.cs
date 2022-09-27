using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Framework.LeadsManager.Infrastructure.Data.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8485), "CategoriaDescription01", new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8496), "Categoria01" },
                    { -2, new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8499), "CategoriaDescription02", new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8501), "Categoria02" },
                    { -3, new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8502), "CategoriaDescription03", new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8504), "Categoria03" },
                    { -4, new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8505), "CategoriaDescription04", new DateTime(2022, 9, 27, 0, 36, 25, 954, DateTimeKind.Local).AddTicks(8506), "Categoria04" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 35, 45, 193, DateTimeKind.Local).AddTicks(1643), new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1600), new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1597), new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1587), new DateTime(2022, 9, 27, 0, 35, 45, 194, DateTimeKind.Local).AddTicks(1592) });
        }
    }
}
