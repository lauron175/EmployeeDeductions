using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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
            get { return 2000M * 26M; }
        }
        public decimal BenefitCost
        {
            get 
            {
                if (FirstName.StartsWith("A", true, CultureInfo.InvariantCulture))
                    return 1000M - ((10M / 100M) * 1000M);
                else
                    return 1000M;
            }
        }
        public decimal TotalBenefitCost
        {
            get
            {
                return Dependents.Sum(x => x.BenefitCost) + BenefitCost;         
            }
        }        
        public List<DependentViewModel> Dependents { get; set; }

        public EmployeeViewModel()
        {
            Dependents = new List<DependentViewModel>();
        }
    }
}