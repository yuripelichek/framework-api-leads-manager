using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Framework.LeadsManager.Infrastructure.Data.Migrations
{
    public partial class SeedCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4429), "CategoriaDescription01", new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4454), "Categoria01" },
                    { -2, new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4460), "CategoriaDescription02", new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4461), "Categoria02" },
                    { -3, new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4463), "CategoriaDescription03", new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4464), "Categoria03" },
                    { -4, new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4466), "CategoriaDescription04", new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4467), "Categoria04" }
                });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 57, 49, 898, DateTimeKind.Local).AddTicks(8097), new DateTime(2022, 9, 26, 23, 57, 49, 900, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(63), new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(47), new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(53) });
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
                values: new object[] { new DateTime(2022, 9, 26, 23, 37, 37, 7, DateTimeKind.Local).AddTicks(9555), new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8787), new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8784), new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8782) });
        }
    }
}
