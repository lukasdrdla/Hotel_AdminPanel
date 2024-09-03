namespace Hotel_AdminPanel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; set; }
    }
}
