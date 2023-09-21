using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Shared.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
