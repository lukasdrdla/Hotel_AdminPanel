using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_AdminPanel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalIdentificationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsEmployed = table.Column<bool>(type: "bit", nullable: false),
                    InsuranceCompanyId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_InsuranceCompanies_InsuranceCompanyId",
                        column: x => x.InsuranceCompanyId,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomStatusId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxAdults = table.Column<int>(type: "int", nullable: false),
                    MaxChildren = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomStatuses_RoomStatusId",
                        column: x => x.RoomStatusId,
                        principalTable: "RoomStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskItems_AspNetUsers_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReservationStatusId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Adults = table.Column<int>(type: "int", nullable: false),
                    Children = table.Column<int>(type: "int", nullable: false),
                    MealPlanId = table.Column<int>(type: "int", nullable: false),
                    SpecialRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_MealPlans_MealPlanId",
                        column: x => x.MealPlanId,
                        principalTable: "MealPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationStatuses_ReservationStatusId",
                        column: x => x.ReservationStatusId,
                        principalTable: "ReservationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guests_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prepayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "DateOfBirth", "DateOfExpiry", "DateOfIssue", "DocumentNumber", "Email", "FirstName", "LastName", "Nationality", "PersonalIdentificationNumber", "Phone", "PlaceOfBirth", "PostalCode", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Hlavní 123", "Praha", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5301), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "jan.novak@example.com", "Jan", "Novák", "Česká republika", "CZ1234567890", "+420123456789", "Praha", "11000", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5302) },
                    { 2, "Náměstí 456", "Brno", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5311), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2029, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "987654321", "petr.svoboda@example.com", "Petr", "Svoboda", "Česká republika", "CZ0987654321", "+420987654321", "Brno", "60200", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5312) },
                    { 3, "Sokolská 789", "Ostrava", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5318), new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "456789123", "marie.cerna@example.com", "Marie", "Černá", "Česká republika", "CZ4567891234", "+420654789123", "Ostrava", "70200", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5319) },
                    { 4, "Jasná 321", "Plzeň", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5325), new DateTime(1988, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2032, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "321654987", "anna.havlickova@example.com", "Anna", "Havlíčková", "Česká republika", "CZ3216549870", "+420321654987", "Plzeň", "30100", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5325) },
                    { 5, "Květná 159", "Liberec", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5331), new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "159753468", "tomas.prochazka@example.com", "Tomáš", "Procházka", "Česká republika", "CZ1597534680", "+420159753468", "Liberec", "46000", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5332) },
                    { 6, "Lípa 753", "Ústí nad Labem", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5338), new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "753951852", "petra.dvorakova@example.com", "Petra", "Dvořáková", "Česká republika", "CZ7539518520", "+420753951852", "Ústí nad Labem", "40000", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5339) },
                    { 7, "Březová 852", "Hradec Králové", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5344), new DateTime(1987, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "852456789", "jakub.novotny@example.com", "Jakub", "Novotný", "Česká republika", "CZ8524567890", "+420852456789", "Hradec Králové", "50000", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5345) },
                    { 8, "Růžová 258", "Zlín", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5351), new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "258963147", "lucie.krejcova@example.com", "Lucie", "Krejčová", "Česká republika", "CZ2589631470", "+420258963147", "Zlín", "76000", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5352) },
                    { 9, "Modrá 369", "Karlovy Vary", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5358), new DateTime(1980, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "369258147", "martin.fiala@example.com", "Martin", "Fiala", "Česká republika", "CZ3692581470", "+420369258147", "Karlovy Vary", "36000", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5358) },
                    { 10, "Violetová 741", "Jihlava", "Česká republika", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5364), new DateTime(1991, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "741852963", "barbora.kovarova@example.com", "Barbora", "Kovářová", "Česká republika", "CZ7418529630", "+420741852963", "Jihlava", "58601", new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5365) }
                });

            migrationBuilder.InsertData(
                table: "InsuranceCompanies",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { 1, "Ulice 1, Praha", "kontakt@pojistovnaA.cz", "Pojišťovna A", "+420123456789", "www.pojistovnaA.cz" },
                    { 2, "Náměstí 2, Brno", "kontakt@pojistovnaB.cz", "Pojišťovna B", "+420987654321", "www.pojistovnaB.cz" },
                    { 3, "Kavárenská 3, Ostrava", "kontakt@pojistovnaC.cz", "Pojišťovna C", "+420654321987", "www.pojistovnaC.cz" },
                    { 4, "Chata 4, Plzeň", "kontakt@pojistovnaD.cz", "Pojišťovna D", "+420321654987", "www.pojistovnaD.cz" },
                    { 5, "Dlouhá 5, Hradec Králové", "kontakt@pojistovnaE.cz", "Pojišťovna E", "+420147258369", "www.pojistovnaE.cz" },
                    { 6, "Zelená 6, Liberec", "kontakt@pojistovnaF.cz", "Pojišťovna F", "+420369258147", "www.pojistovnaF.cz" },
                    { 7, "Modrá 7, Zlín", "kontakt@pojistovnaG.cz", "Pojišťovna G", "+420258369147", "www.pojistovnaG.cz" },
                    { 8, "Křižíkova 8, Karlovy Vary", "kontakt@pojistovnaH.cz", "Pojišťovna H", "+420852456123", "www.pojistovnaH.cz" },
                    { 9, "Zimní 9, Jihlava", "kontakt@pojistovnaI.cz", "Pojišťovna I", "+420951753486", "www.pojistovnaI.cz" },
                    { 10, "Květná 10, Pardubice", "kontakt@pojistovnaJ.cz", "Pojišťovna J", "+420741852963", "www.pojistovnaJ.cz" }
                });

            migrationBuilder.InsertData(
                table: "MealPlans",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Snídaně", 100.00m },
                    { 2, "Polopenze", 250.00m },
                    { 3, "Plná penze", 400.00m },
                    { 4, "Bez stravy", 0.00m },
                    { 5, "Vegetariánský", 300.00m },
                    { 6, "Bezlepkový", 350.00m },
                    { 7, "Dětský", 150.00m }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Confirmed" },
                    { 3, "Checked-in" },
                    { 4, "Checked-out" },
                    { 5, "Cancelled" }
                });

            migrationBuilder.InsertData(
                table: "RoomStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Booked" },
                    { 3, "Maintenance" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Single" },
                    { 2, "Double" },
                    { 3, "Triple" },
                    { 4, "Quad" },
                    { 5, "Queen" },
                    { 6, "King" },
                    { 7, "Twin" },
                    { 8, "Double-double" },
                    { 9, "Studio" },
                    { 10, "Master Suite" },
                    { 11, "Mini Suite" },
                    { 12, "President Suite" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "MaxAdults", "MaxChildren", "Price", "RoomNumber", "RoomStatusId", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5188), "Single Room", "", 1, 0, 100m, "101", 1, 1, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5239) },
                    { 2, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5247), "Double Room", "", 2, 0, 150m, "102", 1, 2, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5248) },
                    { 3, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5249), "Triple Room", "", 3, 0, 200m, "103", 1, 3, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5250) },
                    { 4, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5252), "Quad Room", "", 4, 0, 250m, "104", 1, 4, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5252) },
                    { 5, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5254), "Queen Room", "", 2, 2, 300m, "105", 1, 5, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5255) },
                    { 6, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5256), "King Room", "", 2, 2, 350m, "106", 1, 6, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5257) },
                    { 7, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5259), "Twin Room", "", 2, 2, 400m, "107", 1, 7, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5259) },
                    { 8, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5261), "Double-double Room", "", 4, 0, 450m, "108", 1, 8, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5262) },
                    { 9, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5263), "Studio Room", "", 2, 2, 500m, "109", 1, 9, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5264) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AdminNote", "Adults", "CheckIn", "CheckOut", "Children", "CreatedAt", "CustomerId", "MealPlanId", "ReservationStatusId", "RoomId", "SpecialRequest", "TotalPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5474), 1, 1, 1, 1, "", 0m, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5476) },
                    { 2, "", 2, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5479), 2, 2, 2, 2, "", 0m, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5480) },
                    { 3, "", 3, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5496), 3, 3, 3, 3, "", 0m, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5497) },
                    { 4, "", 4, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5500), 4, 4, 4, 4, "", 0m, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5501) },
                    { 5, "", 2, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5504), 5, 5, 1, 5, "", 0m, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5505) }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedAt", "Currency", "Description", "Discount", "DueDate", "IsPaid", "IssueDate", "Prepayment", "Price", "ReservationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5432), "CZK", "", 0.0m, new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5425), false, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5424), 0.0m, 1500.00m, 1, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5434) },
                    { 2, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5438), "CZK", "", 0.0m, new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5437), true, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5437), 0.0m, 2500.00m, 2, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5439) },
                    { 3, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5443), "CZK", "", 0.0m, new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5442), false, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5442), 0.0m, 1200.00m, 3, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5444) },
                    { 4, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5449), "CZK", "", 0.0m, new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5448), true, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5447), 0.0m, 2000.00m, 4, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5449) },
                    { 5, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5454), "CZK", "", 0.0m, new DateTime(2024, 11, 26, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5453), false, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5452), 0.0m, 1700.00m, 5, new DateTime(2024, 10, 27, 8, 22, 1, 694, DateTimeKind.Local).AddTicks(5455) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_InsuranceCompanyId",
                table: "AspNetUsers",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_ReservationId",
                table: "Guests",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InvoiceId",
                table: "Payments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MealPlanId",
                table: "Reservations",
                column: "MealPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationStatusId",
                table: "Reservations",
                column: "ReservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RoomId",
                table: "Reviews",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomStatusId",
                table: "Rooms",
                column: "RoomStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_EmployeeId1",
                table: "TaskItems",
                column: "EmployeeId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "TaskItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "ReservationStatuses");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomStatuses");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
