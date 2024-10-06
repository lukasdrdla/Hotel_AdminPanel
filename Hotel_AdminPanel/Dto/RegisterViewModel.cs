using System.ComponentModel.DataAnnotations;

namespace Hotel_AdminPanel.Dto
{
    public class RegisterViewModel
    {
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }



    }
}
