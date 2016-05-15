using AutoMapper;
using EmployeeDeductions.Domain.Interfaces;
using EmployeeDeductions.Domain.Models;
using EmployeeDeductions.Web.Models;
using System.Web.Mvc;

namespace EmployeeDeductions.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private IService<Employee> _employeeService;
        
        public EmployeeController(IService<Employee> employeeService)
        {
            _employeeService = employeeService;
        }
        
        public ActionResult Index()
        {
            var employee = _employeeService.Get(1);

            var returnValue = Mapper.Map<Employee, EmployeeViewModel>(employee);
            
            return View(returnValue);
        }        
    }
}