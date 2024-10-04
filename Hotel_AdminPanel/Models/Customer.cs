using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hotel_AdminPanel.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Křestní jméno je povinné.")]
        [StringLength(50, ErrorMessage = "Křestní jméno nesmí přesáhnout 50 znaků.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Příjmení je povinné.")]
        [StringLength(50, ErrorMessage = "Příjmení nesmí přesáhnout 50 znaků.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefonní číslo je povinné.")]
        [Phone(ErrorMessage = "Zadejte platné telefonní číslo.")]
        [StringLength(15, ErrorMessage = "Telefonní číslo nesmí přesáhnout 15 znaků.")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email je povinný.")]
        [EmailAddress(ErrorMessage = "Zadejte platný email.")]
        [StringLength(50, ErrorMessage = "Email nesmí přesáhnout 50 znaků.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adresa je povinná.")]
        [StringLength(100, ErrorMessage = "Adresa nesmí přesáhnout 100 znaků.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Město je povinné.")]
        [StringLength(50, ErrorMessage = "Město nesmí přesáhnout 50 znaků.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "PSČ je povinné.")]
        [RegularExpression(@"\d{5}(-\d{4})?", ErrorMessage = "PSČ musí mít formát 12345 nebo 12345-6789.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Stát je povinný.")]
        [StringLength(50, ErrorMessage = "Název státu nesmí přesáhnout 50 znaků.")]
        public string Country { get; set; } = string.Empty;


    }
}
