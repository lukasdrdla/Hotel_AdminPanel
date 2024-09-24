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
