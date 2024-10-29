using Hotel_AdminPanel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "Profilová Fotka")]
        public string ProfilePicture { get; set; }

        [Required(ErrorMessage = "Email je povinný")]
        [EmailAddress(ErrorMessage = "Neplatný formát emailu")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Heslo je povinné")]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potvrzení hesla je povinné")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hesla se neshodují")]
        [Display(Name = "Potvrzení Hesla")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Jméno je povinné")]
        [StringLength(50, ErrorMessage = "Jméno může mít maximálně 50 znaků")]
        [Display(Name = "Jméno")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Příjmení je povinné")]
        [StringLength(50, ErrorMessage = "Příjmení může mít maximálně 50 znaků")]
        [Display(Name = "Příjmení")]
        public string LastName { get; set; }

        [Display(Name = "Rodné Číslo")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Rodné číslo musí obsahovat 10 čísel")]
        public string PersonalIdentificationNumber { get; set; }

        [Display(Name = "Místo Narození")]
        public string PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "Identifikace pojišťovny je povinná")]
        [Display(Name = "ID Pojišťovny")]
        public int InsuranceCompanyId { get; set; }

        [Display(Name = "Pojišťovna")]
        public InsuranceCompany InsuranceCompany { get; set; }

        [Required(ErrorMessage = "Adresa je povinná")]
        [Display(Name = "Adresa")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Město je povinné")]
        [Display(Name = "Město")]
        public string City { get; set; }

        [Required(ErrorMessage = "PSČ je povinné")]
        [RegularExpression(@"\d{5}", ErrorMessage = "PSČ musí obsahovat 5 čísel")]
        [Display(Name = "PSČ")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Země je povinná")]
        [Display(Name = "Země")]
        public string Country { get; set; }

        [Display(Name = "Pracovní Pozice")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Datum začátku je povinné")]
        [DataType(DataType.Date)]
        [Display(Name = "Datum Nástupu")]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Plat je povinný")]
        [Range(0, double.MaxValue, ErrorMessage = "Plat musí být nezáporné číslo")]
        [DataType(DataType.Currency)]
        [Display(Name = "Plat")]
        public decimal Salary { get; set; }


        [Display(Name = "Telefonní Číslo")]
        [RegularExpression(@"\d{9}", ErrorMessage = "Telefonní číslo musí obsahovat 9 čísel")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Zaměstnán")]
        public bool IsEmployed { get; set; }




    }
}
