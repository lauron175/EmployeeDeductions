using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDeductions.Web.Models
{
    public class DependentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BenefitCost
        {
            get { return 500M; }
        }
    }

}