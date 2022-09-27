using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Framework.LeadsManager.Infrastructure.Data.Migrations
{
    public partial class SeedClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "CreatedAt", "Email", "LastName", "ModifiedAt", "Name", "Phone" },
                values: new object[,]
                {
                    { -6, new DateTime(2022, 9, 26, 23, 37, 37, 7, DateTimeKind.Local).AddTicks(9555), "nome01@xyz.com", "Sobrenome01", new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(7978), "Nome01", "111.000.000" },
                    { -2, new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8776), "nome022@xyz.com", "Sobrenome022", new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8782), "Nome022", "222222.000.000" },
                    { -3, new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8784), "nome033@xyz.com", "Sobrenome033", new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8786), "Nome033", "333333.000.000" },
                    { -4, new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8787), "nome044@xyz.com", "Sobrenome044", new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8788), "Nome044", "444444.000.000" },
                    { -5, new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8790), "nome044@xyz.com", "Sobrenome044", new DateTime(2022, 9, 26, 23, 37, 37, 8, DateTimeKind.Local).AddTicks(8791), "Nome055", "444444.000.000" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2);
        }
    }
}
