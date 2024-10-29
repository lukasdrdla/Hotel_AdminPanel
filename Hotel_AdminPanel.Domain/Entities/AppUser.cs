using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;


namespace Hotel_AdminPanel.Domain.Entities
{
    public class AppUser : IdentityUser
    {

        public string ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PersonalIdentificationNumber { get; set; }
        public string PlaceOfBirth { get; set; }

        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public bool IsEmployed { get; set; }

        public int InsuranceCompanyId { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }



    }
}
