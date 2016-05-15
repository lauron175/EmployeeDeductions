using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDeductions.Web.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Pay
        {
            get { return 2000M; }
        }
        public decimal BenefitCost
        {
            get { return 1000M; }
        }
        public List<DependentViewModel> Dependents { get; set; }

        public EmployeeViewModel()
        {
            Dependents = new List<DependentViewModel>();
        }
    }
}