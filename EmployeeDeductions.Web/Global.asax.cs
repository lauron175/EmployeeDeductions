using EmployeeDeductions.Domain.Models;
using EmployeeDeductions.Web.App_Start;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeDeductions.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            SimpleInjectorInitializer.Initialize();
            AutoMapperInitializer.Initialize();
            CreateTempData();       
        }        

        private void CreateTempData()
        {
            var employees = new List<Employee>();

            var dependent = new Dependent 
            {
                FirstName = "Lori",
                LastName = "Schwartz"
            };

            var dependent2 = new Dependent
            {
                FirstName = "Elle",
                LastName = "Schwartz"
            };

            var employee = new Employee();
            employee.FirstName = "Aichael";
            employee.LastName = "Schwartz";
            employee.EmployeeId = 1;
            employee.Dependents.Add(dependent);
            employee.Dependents.Add(dependent2);

            employees.Add(employee);

            HttpContext.Current.Application["tempEmployees"] = employees;            
        }
    }
}
