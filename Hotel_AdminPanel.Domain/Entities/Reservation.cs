

using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_AdminPanel.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public int ReservationStatusId { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int MealPlanId { get; set; }
        public MealPlan MealPlan { get; set; }
        public string SpecialRequest { get; set; } = "";
        public string AdminNote { get; set; } = "";

        public List<Guest> Guests { get; set; } = new List<Guest>();

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
