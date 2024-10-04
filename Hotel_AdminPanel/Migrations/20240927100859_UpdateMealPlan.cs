using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_AdminPanel.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMealPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RoomStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "MealPlans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "MealPlans");

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

            migrationBuilder.InsertData(
                table: "MealPlans",
                columns: new[] { "Id", "Plan" },
                values: new object[,]
                {
                    { 1, "No Meal" },
                    { 2, "Breakfast" },
                    { 3, "Half Board" },
                    { 4, "Full Board" }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "Id", "RStatus" },
                values: new object[,]
                {
                    { 1, "Reserved" },
                    { 2, "CheckedIn" },
                    { 3, "Completed" },
                    { 4, "Canceled" }
                });

            migrationBuilder.InsertData(
                table: "RoomStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Occupied" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Single" },
                    { 2, "Double" },
                    { 3, "Studio" },
                    { 4, "Suite" },
                    { 5, "MiniSuite" },
                    { 6, "Presidential" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "Image", "MaxAdults", "MaxChildren", "Price", "RoomNumber", "RoomStatusId", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, "", "", 0, 0, 100m, "A101", 1, 1 },
                    { 2, "", "", 0, 0, 150m, "A102", 1, 2 },
                    { 3, "", "", 0, 0, 200m, "A103", 1, 3 },
                    { 4, "", "", 0, 0, 250m, "A104", 1, 4 },
                    { 5, "", "", 0, 0, 300m, "A105", 1, 5 },
                    { 6, "", "", 0, 0, 350m, "A106", 1, 6 }
                });
        }
    }
}
