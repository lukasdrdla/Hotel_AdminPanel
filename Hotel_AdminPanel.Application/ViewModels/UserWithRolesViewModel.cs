using Hotel_AdminPanel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.ViewModels
{
    public class UserWithRolesViewModel
    {
        public AppUser User { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
    }
}
