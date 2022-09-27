using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Framework.LeadsManager.Infrastructure.Data.Migrations
{
    public partial class AddJobSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8783), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8777), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8774), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8766), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6882), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6878), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6876), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6864), new DateTime(2022, 9, 27, 0, 39, 27, 879, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 877, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5328), new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5326), new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5323), new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5316), new DateTime(2022, 9, 27, 0, 39, 27, 878, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Price", "PriceWithDiscount" },
                values: new object[,]
                {
                    { -5, -3, new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(590), "Job005", new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(591), 2000m, 0m },
                    { -4, -4, new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(587), "Job004", new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(588), 1000m, 0m },
                    { -2, -1, new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(581), "Job002", new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(582), 222m, 0m },
                    { -3, -2, new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(584), "Job003", new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(585), 300m, 0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4802), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4799), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4797), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4794), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4786), new DateTime(2022, 9, 27, 0, 36, 58, 556, DateTimeKind.Local).AddTicks(4790) });

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
    }
}
