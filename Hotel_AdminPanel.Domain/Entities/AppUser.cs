using Microsoft.AspNetCore.Identity;


namespace Hotel_AdminPanel.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PersonalIdentificationNumber { get; set; }
        public string PlaceOfBirth { get; set; }

        public int InsuranceCompanyId { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }



    }
}
