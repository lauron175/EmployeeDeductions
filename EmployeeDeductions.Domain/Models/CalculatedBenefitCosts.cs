using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDeductions.Domain.Models
{
    public class CalculatedBenefitCosts
    {
        public decimal TotalDeductions{ get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal SalaryAfterDeductions { get; set; }
    }
}
