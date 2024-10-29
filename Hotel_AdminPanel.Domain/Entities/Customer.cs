
using System.ComponentModel.DataAnnotations;

namespace Hotel_AdminPanel.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Jméno je povinné.")]
        [StringLength(50, ErrorMessage = "Jméno může mít maximálně 50 znaků.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Příjmení je povinné.")]
        [StringLength(50, ErrorMessage = "Příjmení může mít maximálně 50 znaků.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Číslo dokladu je povinné.")]
        [StringLength(20, ErrorMessage = "Číslo dokladu může mít maximálně 20 znaků.")]
        public string DocumentNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Místo narození je povinné.")]
        [StringLength(100, ErrorMessage = "Místo narození může mít maximálně 100 znaků.")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [Required(ErrorMessage = "Datum narození je povinné.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Datum vydání je povinné.")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2100")]
        public DateTime DateOfIssue { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Datum vypršení platnosti je povinné.")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2100")]
        public DateTime DateOfExpiry { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Osobní identifikační číslo je povinné.")]
        [StringLength(20, ErrorMessage = "Osobní identifikační číslo může mít maximálně 20 znaků.")]
        public string PersonalIdentificationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Národnost je povinná.")]
        [StringLength(50, ErrorMessage = "Národnost může mít maximálně 50 znaků.")]
        public string Nationality { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Neplatné telefonní číslo.")]
        public string Phone { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Neplatná e-mailová adresa.")]
        public string Email { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Adresa může mít maximálně 100 znaků.")]
        public string Address { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "Město může mít maximálně 50 znaků.")]
        public string City { get; set; } = string.Empty;

        [StringLength(10, ErrorMessage = "PSČ může mít maximálně 10 znaků.")]
        public string PostalCode { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "Země může mít maximálně 50 znaků.")]
        public string Country { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
