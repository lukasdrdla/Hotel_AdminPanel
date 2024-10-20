

namespace Hotel_AdminPanel.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public int ReservationStatusId { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int MealPlanId { get; set; }
        public MealPlan MealPlan { get; set; }
        public string SpecialRequest { get; set; } = "";
    }
}
