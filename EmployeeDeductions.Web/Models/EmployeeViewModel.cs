using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeDeductions.Web.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
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