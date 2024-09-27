using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_AdminPanel.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "Email", "FirstName", "LastName", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", "CityA", "CountryA", "john.doe@example.com", "John", "Doe", "123456789", "12345" },
                    { 2, "456 Elm St", "CityB", "CountryB", "jane.doe@example.com", "Jane", "Doe", "987654321", "54321" },
                    { 3, "789 Pine St", "CityC", "CountryC", "alice.smith@example.com", "Alice", "Smith", "456789123", "67890" },
                    { 4, "159 Maple St", "CityD", "CountryD", "bob.johnson@example.com", "Bob", "Johnson", "321654987", "13579" },
                    { 5, "753 Oak St", "CityE", "CountryE", "charlie.brown@example.com", "Charlie", "Brown", "258369147", "24680" },
                    { 6, "951 Birch St", "CityF", "CountryF", "david.wilson@example.com", "David", "Wilson", "963852741", "36912" },
                    { 7, "357 Cedar St", "CityG", "CountryG", "eve.davis@example.com", "Eve", "Davis", "147258369", "78901" },
                    { 8, "864 Walnut St", "CityH", "CountryH", "frank.garcia@example.com", "Frank", "Garcia", "753159486", "85246" },
                    { 9, "258 Spruce St", "CityI", "CountryI", "grace.martinez@example.com", "Grace", "Martinez", "951753456", "14789" },
                    { 10, "159 Fir St", "CityJ", "CountryJ", "hank.lopez@example.com", "Hank", "Lopez", "258147369", "96374" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
