using Hotel_AdminPanel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
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

        
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Seed(modelBuilder);

        }

        private void Seed(ModelBuilder modelBuilder)
        {




            modelBuilder.Entity<RoomStatus>().HasData(
                new RoomStatus { Id = 1, Status = "Volno" },
                new RoomStatus { Id = 2, Status = "Obsazeno" }
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
                new Room { Id = 1, RoomNumber = "A101", RoomTypeId = 1, RoomStatusId = 1, Price = 1200, MaxAdults = 2, MaxChildren = 0 },
                new Room { Id = 2, RoomNumber = "A102", RoomTypeId = 2, RoomStatusId = 1, Price = 2000, MaxAdults = 2, MaxChildren = 1 },
                new Room { Id = 3, RoomNumber = "A103", RoomTypeId = 3, RoomStatusId = 1, Price = 4200, MaxAdults = 4, MaxChildren = 2 },
                new Room { Id = 4, RoomNumber = "A104", RoomTypeId = 4, RoomStatusId = 1, Price = 3250, MaxAdults = 2, MaxChildren = 2 },
                new Room { Id = 5, RoomNumber = "A105", RoomTypeId = 5, RoomStatusId = 1, Price = 2300, MaxAdults = 2, MaxChildren = 1 },
                new Room { Id = 6, RoomNumber = "A106", RoomTypeId = 6, RoomStatusId = 1, Price = 5350, MaxAdults = 2, MaxChildren = 0 }
                );





            modelBuilder.Entity<ReservationStatus>().HasData(
                new ReservationStatus { Id = 1, RStatus = "Rezervováno" },
                new ReservationStatus { Id = 2, RStatus = "CheckedIn" },
                new ReservationStatus { Id = 3, RStatus = "Dokončeno" },
                new ReservationStatus { Id = 4, RStatus = "Zrušeno" }
                );

            modelBuilder.Entity<MealPlan>().HasData(
                new MealPlan { Id = 1, Plan = "Bez Jídla" },
                new MealPlan { Id = 2, Plan = "Snídaně" },
                new MealPlan { Id = 3, Plan = "Polo Penze" },
                new MealPlan { Id = 4, Plan = "All-Inclusive" }
                );

            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee { Id = 1, FirstName = "Jan", Surname = "Novák", Email = "j.novak@hoap.com", Image = "" },
            //    new Employee { Id = 2, FirstName = "Petr", Surname = "Svoboda", Email = "p.svoboda@hoap.com", Image = "" },
            //    new Employee { Id = 3, FirstName = "Martina", Surname = "Kovářová", Email = "m.kovarova@hoap.com", Image = "" },
            //    new Employee { Id = 4, FirstName = "Tomáš", Surname = "Dvořák", Email = "t.dvorak@hoap.com", Image = "" },
            //    new Employee { Id = 5, FirstName = "Alena", Surname = "Veselá", Email = "a.vesela@hoap.com", Image = "" },
            //    new Employee { Id = 6, FirstName = "Lucie", Surname = "Králová", Email = "l.kralova@hoap.com", Image = "" },
            //    new Employee { Id = 7, FirstName = "Jiří", Surname = "Beneš", Email = "j.benes@hoap.com", Image = "" }
            //);







        }
    }
}
