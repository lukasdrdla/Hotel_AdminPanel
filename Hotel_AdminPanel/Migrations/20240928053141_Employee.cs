using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_AdminPanel.Migrations
{
    /// <inheritdoc />
    public partial class Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Image", "Surname" },
                values: new object[,]
                {
                    { 1, "j.novak@hoap.com", "Jan", "", "Novák" },
                    { 2, "p.svoboda@hoap.com", "Petr", "", "Svoboda" },
                    { 3, "m.kovarova@hoap.com", "Martina", "", "Kovářová" },
                    { 4, "t.dvorak@hoap.com", "Tomáš", "", "Dvořák" },
                    { 5, "a.vesela@hoap.com", "Alena", "", "Veselá" },
                    { 6, "l.kralova@hoap.com", "Lucie", "", "Králová" },
                    { 7, "j.benes@hoap.com", "Jiří", "", "Beneš" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
