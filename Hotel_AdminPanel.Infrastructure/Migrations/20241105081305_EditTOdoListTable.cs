using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_AdminPanel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditTOdoListTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "TaskItems");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3186), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3192), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3199), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 12, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3293), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 12, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 12, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3307), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3315), new DateTime(2024, 12, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3322), new DateTime(2024, 12, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3365), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3371), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3083), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3095), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3097), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3099), new DateTime(2024, 11, 5, 9, 13, 5, 391, DateTimeKind.Local).AddTicks(3100) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
