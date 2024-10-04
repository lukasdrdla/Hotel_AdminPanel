using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_AdminPanel.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "Email", "FirstName", "LastName", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 1, "Křižíkova 123", "Prague", "Czech Republic", "josef.k@gmail.com", "Josef", "Kramář", "+420 123 456 789", "123 45" },
                    { 2, "Malostranská 456", "Brno", "Czech Republic", "anna.novakova@email.cz", "Anna", "Nováková", "+420 987 654 321", "602 00" },
                    { 3, "Hlavní 789", "Ostrava", "Czech Republic", "petr.svoboda@email.cz", "Petr", "Svoboda", "+420 321 654 987", "700 30" },
                    { 4, "Nádražní 321", "Plzeň", "Czech Republic", "lucie.cerna@email.cz", "Lucie", "Černá", "+420 654 321 987", "301 00" },
                    { 5, "Masarykova 123", "Liberec", "Czech Republic", "jan.dvorak@email.cz", "Jan", "Dvořák", "+420 741 852 963", "460 01" },
                    { 6, "Tylova 456", "Olomouc", "Czech Republic", "katerina.vesela@email.cz", "Kateřina", "Veselá", "+420 951 753 852", "779 00" },
                    { 7, "Husova 789", "Hradec Králové", "Czech Republic", "miroslav.prochazka@email.cz", "Miroslav", "Procházka", "+420 369 852 147", "500 02" },
                    { 8, "Karlova 321", "České Budějovice", "Czech Republic", "eva.horakova@email.cz", "Eva", "Horáková", "+420 753 159 357", "370 01" },
                    { 9, "Jiráskova 456", "Zlín", "Czech Republic", "tomas.kral@email.cz", "Tomáš", "Král", "+420 963 852 741", "760 01" },
                    { 10, "Slovanská 789", "Pardubice", "Czech Republic", "alena.benesova@email.cz", "Alena", "Benešová", "+420 852 147 963", "530 02" },
                    { 11, "Štefánikova 123", "Karlovy Vary", "Czech Republic", "vladimir.zeleny@email.cz", "Vladimír", "Zelený", "+420 159 753 357", "360 01" }
                });

            migrationBuilder.InsertData(
                table: "MealPlans",
                columns: new[] { "Id", "Plan", "Price" },
                values: new object[,]
                {
                    { 1, "Bez Jídla", 0m },
                    { 2, "Snídaně", 0m },
                    { 3, "Polo Penze", 0m },
                    { 4, "All-Inclusive", 0m }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "Id", "RStatus" },
                values: new object[,]
                {
                    { 1, "Rezervováno" },
                    { 2, "CheckedIn" },
                    { 3, "Dokončeno" },
                    { 4, "Zrušeno" }
                });

            migrationBuilder.InsertData(
                table: "RoomStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Volno" },
                    { 2, "Obsazeno" }
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
                    { 1, "", "", 0, 0, 1200m, "A101", 1, 1 },
                    { 2, "", "", 0, 0, 2000m, "A102", 1, 2 },
                    { 3, "", "", 0, 0, 2200m, "A103", 1, 3 },
                    { 4, "", "", 0, 0, 3250m, "A104", 1, 4 },
                    { 5, "", "", 0, 0, 2300m, "A105", 1, 5 },
                    { 6, "", "", 0, 0, 5350m, "A106", 1, 6 }
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

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

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
        }
    }
}
