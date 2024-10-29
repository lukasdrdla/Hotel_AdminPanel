
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel_AdminPanel.Domain.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Číslo pokoje je povinné.")]
        [StringLength(50, ErrorMessage = "Číslo pokoje nesmí být delší než 50 znaků.")]
        public string RoomNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Typ pokoje je povinný.")]
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }

        public RoomType RoomType { get; set; }

        [Required(ErrorMessage = "Status pokoje je povinný.")]
        [ForeignKey("RoomStatus")]
        public int RoomStatusId { get; set; }

        public RoomStatus RoomStatus { get; set; }

        [StringLength(500, ErrorMessage = "Popis nesmí být delší než 500 znaků.")]
        public string Description { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Cena musí být kladná hodnota.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Url(ErrorMessage = "Neplatná URL adresa obrázku.")]
        public string Image { get; set; } = string.Empty;

        [Range(1, 10, ErrorMessage = "Počet dospělých musí být mezi 1 a 10.")]
        public int MaxAdults { get; set; }

        [Range(0, 10, ErrorMessage = "Počet dětí musí být mezi 0 a 10.")]
        public int MaxChildren { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
