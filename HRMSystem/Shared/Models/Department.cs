using Microsoft.CodeAnalysis.Elfie.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Shared.Models
{
    public class Department
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public IList<Employee> Leads { get; set; } = new List<Employee>();
    }
}
