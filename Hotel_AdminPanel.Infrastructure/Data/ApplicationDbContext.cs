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
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            SeedData(builder);
        }

        private void SeedData(ModelBuilder modelBuilder) {

            modelBuilder.Entity<MealPlan>().HasData(
               new MealPlan { Id = 1, Plan = "Snídaně", Price = 150.00m },
               new MealPlan { Id = 2, Plan = "Polopenze", Price = 350.00m },
               new MealPlan { Id = 3, Plan = "Plná penze", Price = 500.00m },
               new MealPlan { Id = 4, Plan = "All-Inclusive", Price = 750.00m },
               new MealPlan { Id = 5, Plan = "Večeře pouze", Price = 200.00m }
           );

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Type = "Standardní jednolůžkový" },
                new RoomType { Id = 2, Type = "Standardní dvojlůžkový" },
                new RoomType { Id = 3, Type = "Luxusní apartmán s vířivkou" },
                new RoomType { Id = 4, Type = "Rodinný pokoj s kuchyňkou" },
                new RoomType { Id = 5, Type = "Business pokoj" },
                new RoomType { Id = 6, Type = "Pokoj pro hosty se zvířaty" },
                new RoomType { Id = 7, Type = "Ekonomický pokoj" },
                new RoomType { Id = 8, Type = "Penthouse" },
                new RoomType { Id = 9, Type = "Pokoj s výhledem na moře" },
                new RoomType { Id = 10, Type = "Pokoj s terasou" }
            );

            modelBuilder.Entity<ReservationStatus>().HasData(
                new ReservationStatus { Id = 1, RStatus = "Čekající" },
                new ReservationStatus { Id = 2, RStatus = "Potvrzená" },
                new ReservationStatus { Id = 3, RStatus = "Zrušená" },
                new ReservationStatus { Id = 4, RStatus = "Dokončená" },
                new ReservationStatus { Id = 5, RStatus = "Odmítnutá" }
            );

            modelBuilder.Entity<RoomStatus>().HasData(
                new RoomStatus { Id = 1, Status = "Volný" },
                new RoomStatus { Id = 2, Status = "Obsazený" },
                new RoomStatus { Id = 3, Status = "Údržba" },
                new RoomStatus { Id = 4, Status = "Čištění" }
            );
        }

    }
}
