using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Domain.Entities
{
    using Hotel_AdminPanel.Domain.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Invoice
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Rezervace je povinná.")]
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        [Required(ErrorMessage = "Datum vystavení je povinné.")]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Datum splatnosti je povinné.")]
        [DataType(DataType.Date)]
        [DateGreaterThan("IssueDate", ErrorMessage = "Datum splatnosti musí být pozdější než datum vystavení.")]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(14);

        [Required(ErrorMessage = "Cena je povinná.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cena musí být kladná.")]
        public decimal Price { get; set; }

        public bool IsPaid { get; set; } = false;

        [StringLength(500, ErrorMessage = "Popis může mít maximálně 500 znaků.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Měna je povinná.")]
        [StringLength(3, ErrorMessage = "Měna musí mít maximálně 3 znaky.")]
        public string Currency { get; set; } = "CZK";

        [Range(0.0, double.MaxValue, ErrorMessage = "Sleva musí být kladná.")]
        public decimal Discount { get; set; } = 0.0m;

        [Range(0.0, double.MaxValue, ErrorMessage = "Záloha musí být kladná.")]
        public decimal Prepayment { get; set; } = 0.0m;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public ICollection<Payment> Payments { get; set; }
    }

}
