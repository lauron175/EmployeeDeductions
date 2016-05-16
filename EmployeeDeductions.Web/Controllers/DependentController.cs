using AutoMapper;
using EmployeeDeductions.Domain.Interfaces;
using EmployeeDeductions.Domain.Models;
using EmployeeDeductions.Web.Models;
using System.Web.Mvc;

namespace EmployeeDeductions.Web.Controllers
{
    public class DependentController : Controller
    {
        private IDependentService _dependentService;

        public DependentController(IDependentService dependentService)
        {
            _dependentService = dependentService;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DependentViewModel dependent)
        {
            var dependentTranslated = Mapper.Map<DependentViewModel, Dependent>(dependent);

            _dependentService.Create(dependentTranslated);

            return View();
        }
    }
}