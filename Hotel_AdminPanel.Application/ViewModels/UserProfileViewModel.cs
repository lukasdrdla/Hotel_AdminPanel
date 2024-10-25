using Hotel_AdminPanel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.ViewModels
{
    public class UserProfileViewModel
    {
        public string ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PersonalIdentificationNumber { get; set; }
        public string PlaceOfBirth { get; set; }

        public int InsuranceCompanyId { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
