using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_AdminPanel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpgradeTaskItemTablev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "TaskItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6885), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6894), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6911), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6927), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6964), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6989), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 12, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 12, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 12, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 12, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 12, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7093), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7122), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7130), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7136), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7143), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6825), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6834), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6836), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6839), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 11, 4, 12, 13, 26, 324, DateTimeKind.Local).AddTicks(6843) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "TaskItems");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5464), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5471), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5478), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5484), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5491), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5504), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5523), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 12, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 12, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5594), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 12, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 12, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5607), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 12, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5641), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5664), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5365), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5367), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5374), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 11, 4, 8, 28, 35, 149, DateTimeKind.Local).AddTicks(5380) });
        }
    }
}
