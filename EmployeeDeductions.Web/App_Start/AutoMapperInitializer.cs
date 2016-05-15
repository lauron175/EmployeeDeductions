using AutoMapper;
using EmployeeDeductions.Domain.Models;
using EmployeeDeductions.Web.Models;

namespace EmployeeDeductions.Web.App_Start
{
    public static class AutoMapperInitializer
    {
        public static void Initialize()
        {
            Mapper.CreateMap<Dependent, DependentViewModel>().ReverseMap();
            Mapper.CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }        
    }
}