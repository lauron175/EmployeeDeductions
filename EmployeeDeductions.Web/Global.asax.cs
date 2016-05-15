using AutoMapper;
using EmployeeDeductions.Domain.Models;
using EmployeeDeductions.Web.App_Start;
using EmployeeDeductions.Web.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeDeductions.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            SimpleInjectorInitializer.Initialize();            

            Mapper.CreateMap<Dependent, DependentViewModel>().ReverseMap();
            Mapper.CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }        
    }
}
