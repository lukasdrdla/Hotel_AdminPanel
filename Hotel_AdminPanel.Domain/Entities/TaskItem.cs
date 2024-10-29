using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public AppUser Employee { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; }

    }
}
