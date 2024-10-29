using Hotel_AdminPanel.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace Hotel_AdminPanel.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }

        public DbSet<TaskItem> TaskItems { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.CustomerId);

            SeedData(builder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RoomStatus>().HasData(
                new RoomStatus { Id = 1, Name = "Available" },
                new RoomStatus { Id = 2, Name = "Booked" },
                new RoomStatus { Id = 3, Name = "Maintenance" }
            );

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Single" },
                new RoomType { Id = 2, Name = "Double" },
                new RoomType { Id = 3, Name = "Triple" },
                new RoomType { Id = 4, Name = "Quad" },
                new RoomType { Id = 5, Name = "Queen" },
                new RoomType { Id = 6, Name = "King" },
                new RoomType { Id = 7, Name = "Twin" },
                new RoomType { Id = 8, Name = "Double-double" },
                new RoomType { Id = 9, Name = "Studio" },
                new RoomType { Id = 10, Name = "Master Suite" },
                new RoomType { Id = 11, Name = "Mini Suite" },
                new RoomType { Id = 12, Name = "President Suite" }
            );

            modelBuilder.Entity<ReservationStatus>().HasData(
                new ReservationStatus { Id = 1, Name = "Pending" },
                new ReservationStatus { Id = 2, Name = "Confirmed" },
                new ReservationStatus { Id = 3, Name = "Checked-in" },
                new ReservationStatus { Id = 4, Name = "Checked-out" },
                new ReservationStatus { Id = 5, Name = "Cancelled" }
            );


            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "101", RoomTypeId = 1, RoomStatusId = 1, Description = "Single Room", Price = 100, MaxAdults = 1, MaxChildren = 0 },
                new Room { Id = 2, RoomNumber = "102", RoomTypeId = 2, RoomStatusId = 1, Description = "Double Room", Price = 150, MaxAdults = 2, MaxChildren = 0 },
                new Room { Id = 3, RoomNumber = "103", RoomTypeId = 3, RoomStatusId = 1, Description = "Triple Room", Price = 200, MaxAdults = 3, MaxChildren = 0 },
                new Room { Id = 4, RoomNumber = "104", RoomTypeId = 4, RoomStatusId = 1, Description = "Quad Room", Price = 250, MaxAdults = 4, MaxChildren = 0 },
                new Room { Id = 5, RoomNumber = "105", RoomTypeId = 5, RoomStatusId = 1, Description = "Queen Room", Price = 300, MaxAdults = 2, MaxChildren = 2 },
                new Room { Id = 6, RoomNumber = "106", RoomTypeId = 6, RoomStatusId = 1, Description = "King Room", Price = 350, MaxAdults = 2, MaxChildren = 2 },
                new Room { Id = 7, RoomNumber = "107", RoomTypeId = 7, RoomStatusId = 1, Description = "Twin Room", Price = 400, MaxAdults = 2, MaxChildren = 2 },
                new Room { Id = 8, RoomNumber = "108", RoomTypeId = 8, RoomStatusId = 1, Description = "Double-double Room", Price = 450, MaxAdults = 4, MaxChildren = 0 },
                new Room { Id = 9, RoomNumber = "109", RoomTypeId = 9, RoomStatusId = 1, Description = "Studio Room", Price = 500, MaxAdults = 2, MaxChildren = 2 }
                );


            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Jan", LastName = "Novák", DocumentNumber = "123456789", PlaceOfBirth = "Praha", DateOfBirth = new DateTime(1990, 1, 1), DateOfIssue = new DateTime(2020, 1, 1), DateOfExpiry = new DateTime(2030, 1, 1), PersonalIdentificationNumber = "CZ1234567890", Nationality = "Česká republika", Phone = "+420123456789", Email = "jan.novak@example.com", Address = "Hlavní 123", City = "Praha", PostalCode = "11000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 2, FirstName = "Petr", LastName = "Svoboda", DocumentNumber = "987654321", PlaceOfBirth = "Brno", DateOfBirth = new DateTime(1985, 5, 15), DateOfIssue = new DateTime(2019, 6, 10), DateOfExpiry = new DateTime(2029, 6, 10), PersonalIdentificationNumber = "CZ0987654321", Nationality = "Česká republika", Phone = "+420987654321", Email = "petr.svoboda@example.com", Address = "Náměstí 456", City = "Brno", PostalCode = "60200", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 3, FirstName = "Marie", LastName = "Černá", DocumentNumber = "456789123", PlaceOfBirth = "Ostrava", DateOfBirth = new DateTime(1992, 3, 25), DateOfIssue = new DateTime(2021, 7, 20), DateOfExpiry = new DateTime(2031, 7, 20), PersonalIdentificationNumber = "CZ4567891234", Nationality = "Česká republika", Phone = "+420654789123", Email = "marie.cerna@example.com", Address = "Sokolská 789", City = "Ostrava", PostalCode = "70200", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 4, FirstName = "Anna", LastName = "Havlíčková", DocumentNumber = "321654987", PlaceOfBirth = "Plzeň", DateOfBirth = new DateTime(1988, 8, 30), DateOfIssue = new DateTime(2022, 4, 15), DateOfExpiry = new DateTime(2032, 4, 15), PersonalIdentificationNumber = "CZ3216549870", Nationality = "Česká republika", Phone = "+420321654987", Email = "anna.havlickova@example.com", Address = "Jasná 321", City = "Plzeň", PostalCode = "30100", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 5, FirstName = "Tomáš", LastName = "Procházka", DocumentNumber = "159753468", PlaceOfBirth = "Liberec", DateOfBirth = new DateTime(1995, 12, 12), DateOfIssue = new DateTime(2021, 11, 11), DateOfExpiry = new DateTime(2031, 11, 11), PersonalIdentificationNumber = "CZ1597534680", Nationality = "Česká republika", Phone = "+420159753468", Email = "tomas.prochazka@example.com", Address = "Květná 159", City = "Liberec", PostalCode = "46000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 6, FirstName = "Petra", LastName = "Dvořáková", DocumentNumber = "753951852", PlaceOfBirth = "Ústí nad Labem", DateOfBirth = new DateTime(1998, 10, 20), DateOfIssue = new DateTime(2020, 8, 15), DateOfExpiry = new DateTime(2030, 8, 15), PersonalIdentificationNumber = "CZ7539518520", Nationality = "Česká republika", Phone = "+420753951852", Email = "petra.dvorakova@example.com", Address = "Lípa 753", City = "Ústí nad Labem", PostalCode = "40000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 7, FirstName = "Jakub", LastName = "Novotný", DocumentNumber = "852456789", PlaceOfBirth = "Hradec Králové", DateOfBirth = new DateTime(1987, 4, 5), DateOfIssue = new DateTime(2021, 5, 1), DateOfExpiry = new DateTime(2031, 5, 1), PersonalIdentificationNumber = "CZ8524567890", Nationality = "Česká republika", Phone = "+420852456789", Email = "jakub.novotny@example.com", Address = "Březová 852", City = "Hradec Králové", PostalCode = "50000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 8, FirstName = "Lucie", LastName = "Krejčová", DocumentNumber = "258963147", PlaceOfBirth = "Zlín", DateOfBirth = new DateTime(1993, 11, 11), DateOfIssue = new DateTime(2021, 3, 12), DateOfExpiry = new DateTime(2031, 3, 12), PersonalIdentificationNumber = "CZ2589631470", Nationality = "Česká republika", Phone = "+420258963147", Email = "lucie.krejcova@example.com", Address = "Růžová 258", City = "Zlín", PostalCode = "76000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 9, FirstName = "Martin", LastName = "Fiala", DocumentNumber = "369258147", PlaceOfBirth = "Karlovy Vary", DateOfBirth = new DateTime(1980, 9, 9), DateOfIssue = new DateTime(2018, 4, 20), DateOfExpiry = new DateTime(2028, 4, 20), PersonalIdentificationNumber = "CZ3692581470", Nationality = "Česká republika", Phone = "+420369258147", Email = "martin.fiala@example.com", Address = "Modrá 369", City = "Karlovy Vary", PostalCode = "36000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 10, FirstName = "Barbora", LastName = "Kovářová", DocumentNumber = "741852963", PlaceOfBirth = "Jihlava", DateOfBirth = new DateTime(1991, 6, 15), DateOfIssue = new DateTime(2021, 9, 15), DateOfExpiry = new DateTime(2031, 9, 15), PersonalIdentificationNumber = "CZ7418529630", Nationality = "Česká republika", Phone = "+420741852963", Email = "barbora.kovarova@example.com", Address = "Violetová 741", City = "Jihlava", PostalCode = "58601", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<InsuranceCompany>().HasData(
                new InsuranceCompany { Id = 1, Name = "Pojišťovna A", Address = "Ulice 1, Praha", PhoneNumber = "+420123456789", Email = "kontakt@pojistovnaA.cz", Website = "www.pojistovnaA.cz" },
                new InsuranceCompany { Id = 2, Name = "Pojišťovna B", Address = "Náměstí 2, Brno", PhoneNumber = "+420987654321", Email = "kontakt@pojistovnaB.cz", Website = "www.pojistovnaB.cz" },
                new InsuranceCompany { Id = 3, Name = "Pojišťovna C", Address = "Kavárenská 3, Ostrava", PhoneNumber = "+420654321987", Email = "kontakt@pojistovnaC.cz", Website = "www.pojistovnaC.cz" },
                new InsuranceCompany { Id = 4, Name = "Pojišťovna D", Address = "Chata 4, Plzeň", PhoneNumber = "+420321654987", Email = "kontakt@pojistovnaD.cz", Website = "www.pojistovnaD.cz" },
                new InsuranceCompany { Id = 5, Name = "Pojišťovna E", Address = "Dlouhá 5, Hradec Králové", PhoneNumber = "+420147258369", Email = "kontakt@pojistovnaE.cz", Website = "www.pojistovnaE.cz" },
                new InsuranceCompany { Id = 6, Name = "Pojišťovna F", Address = "Zelená 6, Liberec", PhoneNumber = "+420369258147", Email = "kontakt@pojistovnaF.cz", Website = "www.pojistovnaF.cz" },
                new InsuranceCompany { Id = 7, Name = "Pojišťovna G", Address = "Modrá 7, Zlín", PhoneNumber = "+420258369147", Email = "kontakt@pojistovnaG.cz", Website = "www.pojistovnaG.cz" },
                new InsuranceCompany { Id = 8, Name = "Pojišťovna H", Address = "Křižíkova 8, Karlovy Vary", PhoneNumber = "+420852456123", Email = "kontakt@pojistovnaH.cz", Website = "www.pojistovnaH.cz" },
                new InsuranceCompany { Id = 9, Name = "Pojišťovna I", Address = "Zimní 9, Jihlava", PhoneNumber = "+420951753486", Email = "kontakt@pojistovnaI.cz", Website = "www.pojistovnaI.cz" },
                new InsuranceCompany { Id = 10, Name = "Pojišťovna J", Address = "Květná 10, Pardubice", PhoneNumber = "+420741852963", Email = "kontakt@pojistovnaJ.cz", Website = "www.pojistovnaJ.cz" }
            );

            modelBuilder.Entity<Invoice>().HasData(
               new Invoice { Id = 1, ReservationId = 1, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 1500.00m, IsPaid = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new Invoice { Id = 2, ReservationId = 2, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 2500.00m, IsPaid = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new Invoice { Id = 3, ReservationId = 3, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 1200.00m, IsPaid = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new Invoice { Id = 4, ReservationId = 4, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 2000.00m, IsPaid = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new Invoice { Id = 5, ReservationId = 5, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 1700.00m, IsPaid = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
           );


            modelBuilder.Entity<Reservation>().HasData(
                new Reservation {Id = 1, CustomerId = 1, RoomId = 1, CheckIn = new DateTime(2022, 1, 1), CheckOut = new DateTime(2022, 1, 5), Adults = 1, Children = 0, MealPlanId = 1, ReservationStatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Reservation { Id = 2, CustomerId = 2, RoomId = 2, CheckIn = new DateTime(2022, 1, 2), CheckOut = new DateTime(2022, 1, 6), Adults = 2, Children = 0, MealPlanId = 2, ReservationStatusId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Reservation { Id = 3, CustomerId = 3, RoomId = 3, CheckIn = new DateTime(2022, 1, 3), CheckOut = new DateTime(2022, 1, 7), Adults = 3, Children = 0, MealPlanId = 3, ReservationStatusId = 3, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Reservation { Id = 4, CustomerId = 4, RoomId = 4, CheckIn = new DateTime(2022, 1, 4), CheckOut = new DateTime(2022, 1, 8), Adults = 4, Children = 0, MealPlanId = 4, ReservationStatusId = 4, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Reservation { Id = 5, CustomerId = 5, RoomId = 5, CheckIn = new DateTime(2022, 1, 5), CheckOut = new DateTime(2022, 1, 9), Adults = 2, Children = 2, MealPlanId = 5, ReservationStatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
                );


            modelBuilder.Entity<MealPlan>().HasData(
                new MealPlan { Id = 1, Name = "Snídaně", Price = 100.00m },
                new MealPlan { Id = 2, Name = "Polopenze", Price = 250.00m },
                new MealPlan { Id = 3, Name = "Plná penze", Price = 400.00m },
                new MealPlan { Id = 4, Name = "Bez stravy", Price = 0.00m },
                new MealPlan { Id = 5, Name = "Vegetariánský", Price = 300.00m },
                new MealPlan { Id = 6, Name = "Bezlepkový", Price = 350.00m },
                new MealPlan { Id = 7, Name = "Dětský", Price = 150.00m }
            );


        }

    }
}
