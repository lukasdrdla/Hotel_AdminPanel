using Hotel_AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }
        public DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            //vygenerováno pomocí chatgpt
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Phone = "123456789", Address = "123 Main St", City = "CityA", Country = "CountryA", PostalCode = "12345" },
                new Customer { Id = 2, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com", Phone = "987654321", Address = "456 Elm St", City = "CityB", Country = "CountryB", PostalCode = "54321" },
                new Customer { Id = 3, FirstName = "Alice", LastName = "Smith", Email = "alice.smith@example.com", Phone = "456789123", Address = "789 Pine St", City = "CityC", Country = "CountryC", PostalCode = "67890" },
                new Customer { Id = 4, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", Phone = "321654987", Address = "159 Maple St", City = "CityD", Country = "CountryD", PostalCode = "13579" },
                new Customer { Id = 5, FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@example.com", Phone = "258369147", Address = "753 Oak St", City = "CityE", Country = "CountryE", PostalCode = "24680" },
                new Customer { Id = 6, FirstName = "David", LastName = "Wilson", Email = "david.wilson@example.com", Phone = "963852741", Address = "951 Birch St", City = "CityF", Country = "CountryF", PostalCode = "36912" },
                new Customer { Id = 7, FirstName = "Eve", LastName = "Davis", Email = "eve.davis@example.com", Phone = "147258369", Address = "357 Cedar St", City = "CityG", Country = "CountryG", PostalCode = "78901" },
                new Customer { Id = 8, FirstName = "Frank", LastName = "Garcia", Email = "frank.garcia@example.com", Phone = "753159486", Address = "864 Walnut St", City = "CityH", Country = "CountryH", PostalCode = "85246" },
                new Customer { Id = 9, FirstName = "Grace", LastName = "Martinez", Email = "grace.martinez@example.com", Phone = "951753456", Address = "258 Spruce St", City = "CityI", Country = "CountryI", PostalCode = "14789" },
                new Customer { Id = 10, FirstName = "Hank", LastName = "Lopez", Email = "hank.lopez@example.com", Phone = "258147369", Address = "159 Fir St", City = "CityJ", Country = "CountryJ", PostalCode = "96374" }
            );


            modelBuilder.Entity<RoomStatus>().HasData(
                new RoomStatus { Id = 1, Status = "Available" },
                new RoomStatus { Id = 2, Status = "Occupied" }
                );

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Type = "Single" },
                new RoomType { Id = 2, Type = "Double" },
                new RoomType { Id = 3, Type = "Studio" },
                new RoomType { Id = 4, Type = "Suite" },
                new RoomType { Id = 5, Type = "MiniSuite" },
                new RoomType { Id = 6, Type = "Presidential" }
                );

            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "A101", RoomTypeId = 1, RoomStatusId = 1, Price = 100 },
                new Room { Id = 2, RoomNumber = "A102", RoomTypeId = 2, RoomStatusId = 1, Price = 150 },
                new Room { Id = 3, RoomNumber = "A103", RoomTypeId = 3, RoomStatusId = 1, Price = 200 },
                new Room { Id = 4, RoomNumber = "A104", RoomTypeId = 4, RoomStatusId = 1, Price = 250 },
                new Room { Id = 5, RoomNumber = "A105", RoomTypeId = 5, RoomStatusId = 1, Price = 300 },
                new Room { Id = 6, RoomNumber = "A106", RoomTypeId = 6, RoomStatusId = 1, Price = 350 }
                );





            modelBuilder.Entity<ReservationStatus>().HasData(
                new ReservationStatus { Id = 1, RStatus = "Reserved" },
                new ReservationStatus { Id = 2, RStatus = "CheckedIn" },
                new ReservationStatus { Id = 3, RStatus = "Completed" },
                new ReservationStatus { Id = 4, RStatus = "Canceled" }
                );

            modelBuilder.Entity<MealPlan>().HasData(
                new MealPlan { Id = 1, Plan = "No Meal" },
                new MealPlan { Id = 2, Plan = "Breakfast" },
                new MealPlan { Id = 3, Plan = "Half Board" },
                new MealPlan { Id = 4, Plan = "Full Board" }
                );






        }
    }
}
