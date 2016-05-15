using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDeductions.Domain.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Pay { get; set; }
        public decimal BenefitCost { get; set; }
        public List<Dependent> Dependents { get; set; }

        public Employee()
        {
            Dependents = new List<Dependent>();
        }
    }
}
