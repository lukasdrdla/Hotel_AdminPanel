using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_AdminPanel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpgradeTaskItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_AspNetUsers_EmployeeId1",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_EmployeeId1",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "TaskItems");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "TaskItems",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Rooms",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rooms",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Invoices",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Invoices",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_EmployeeId",
                table: "TaskItems",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_AspNetUsers_EmployeeId",
                table: "TaskItems",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_AspNetUsers_EmployeeId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_EmployeeId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "TaskItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "TaskItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5358), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5432), new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5425), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5424), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5438), new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5443), new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5442), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5442), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5449), new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5448), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5454), new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5453), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5496), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5504), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5247), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5252), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5259), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5261), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5263), new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_EmployeeId1",
                table: "TaskItems",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_AspNetUsers_EmployeeId1",
                table: "TaskItems",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
