
namespace Hotel_AdminPanel.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public int RoomStatusId { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public int MaxAdults { get; set; }
        public int MaxChildren { get; set; }
    }
}
