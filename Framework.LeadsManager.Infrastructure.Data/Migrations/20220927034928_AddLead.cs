using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Framework.LeadsManager.Infrastructure.Data.Migrations
{
    public partial class AddLead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7458), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7455), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7452), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7448), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7439), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5322), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5319), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5317), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5304), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 790, DateTimeKind.Local).AddTicks(4149), new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3118), new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3115), new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3112), new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 9, 27, 0, 49, 27, 792, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9213), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9210), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9206), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9203), new DateTime(2022, 9, 27, 0, 49, 27, 793, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.InsertData(
                table: "Lead",
                columns: new[] { "Id", "Approved", "ClientId", "CreatedAt", "JobId", "ModifiedAt" },
                values: new object[,]
                {
                    { -5, null, -5, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(352), -5, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(353) },
                    { -4, null, -4, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(349), -4, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(350) },
                    { -3, null, -3, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(346), -3, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(347) },
                    { -2, null, -2, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(339), -2, new DateTime(2022, 9, 27, 0, 49, 27, 794, DateTimeKind.Local).AddTicks(343) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Lead",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Lead",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Lead",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Lead",
                keyColumn: "Id",
                keyValue: -2);

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

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(590), new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(587), new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(584), new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(581), new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Price", "PriceWithDiscount" },
                values: new object[] { -1, -1, new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(570), "Job001", new DateTime(2022, 9, 27, 0, 39, 27, 880, DateTimeKind.Local).AddTicks(576), 100m, 0m });
        }
    }
}
