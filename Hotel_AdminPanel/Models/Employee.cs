using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Hotel_AdminPanel.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
