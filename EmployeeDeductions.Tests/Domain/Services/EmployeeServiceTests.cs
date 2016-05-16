using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using EmployeeDeductions.Domain.Models;
using AutoMapper;
using EmployeeDeductions.Web.Models;
using EmployeeDeductions.Domain.Services;
using EmployeeDeductions.Domain.Interfaces;

namespace EmployeeDeductions.Tests.Domain.Services
{
    [TestClass]
    public class EmployeeServiceTests
    {
        private Mock<IRepository<Employee>> _employeeRepositoryMock;
        private EmployeeService _employeeService;
        private Employee _employee;

        [TestInitialize]
        public void Initialize()
        {
            _employeeRepositoryMock = new Mock<IRepository<Employee>>();
            _employeeService = new EmployeeService(_employeeRepositoryMock.Object);                  

            Mapper.CreateMap<Dependent, DependentViewModel>().ReverseMap();
            Mapper.CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }

        [TestMethod]
        public void CalculateBenefitCosts_EmployeeOnlyNoDiscount_ReturnsValidCost()
        {
            //Arrange
            _employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Mike",
                LastName = "Schwartz"
            };            

            _employeeRepositoryMock.Setup(x => x.Get(1)).Returns(_employee);

            //Act
            var response = _employeeService.Get(1);

            var employeeMapped = Mapper.Map<Employee, EmployeeViewModel>(_employee);

            //Assert
            Assert.AreEqual(1000M, employeeMapped.TotalBenefitCost);
        }

        [TestMethod]
        public void CalculateBenefitCosts_EmployeeOnlyWithDiscount_ReturnsValidCost()
        {
            //Arrange
            _employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Andy",
                LastName = "Schwartz"
            };

            //Act
            _employeeRepositoryMock.Setup(x => x.Get(1)).Returns(_employee);

            var employeeMapped = Mapper.Map<Employee, EmployeeViewModel>(_employee);

            //Assert
            Assert.AreEqual(900M, employeeMapped.TotalBenefitCost);
        }

        [TestMethod]
        public void CalculateBenefitCosts_EmployeeWithOneDependentNoDiscount_ReturnsValidCost()
        {
            //Arrange
            _employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Mike",
                LastName = "Schwartz"
            };

            var dependent1 = new Dependent()
            {
                FirstName = "Elle",
                LastName = "Schwartz"
            };

            _employee.Dependents.Add(dependent1);

            //Act
            _employeeRepositoryMock.Setup(x => x.Get(1)).Returns(_employee);

            var employeeMapped = Mapper.Map<Employee, EmployeeViewModel>(_employee);

            //Assert
            Assert.AreEqual(1500M, employeeMapped.TotalBenefitCost);
        }

        [TestMethod]
        public void CalculateBenefitCosts_EmployeeWithTwoDependentsNoDiscount_ReturnsValidCost()
        {
            //Arrange
            _employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Mike",
                LastName = "Schwartz"
            };

            var dependent1 = new Dependent()
            {
                FirstName = "Elle",
                LastName = "Schwartz"
            };

            var dependent2 = new Dependent()
            {
                FirstName = "Lori",
                LastName = "Schwartz"
            };

            _employee.Dependents.Add(dependent1);
            _employee.Dependents.Add(dependent2);

            //Act
            _employeeRepositoryMock.Setup(x => x.Get(1)).Returns(_employee);

            var employeeMapped = Mapper.Map<Employee, EmployeeViewModel>(_employee);

            //Assert
            Assert.AreEqual(2000M, employeeMapped.TotalBenefitCost);
        }       

        [TestMethod]
        public void CalculateBenefitCosts_EmployeeWithOneDependentThatHasDiscount_ReturnsValidCost()
        {
            //Arrange
            _employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Mike",
                LastName = "Schwartz"
            };

            var dependent1 = new Dependent()
            {
                FirstName = "Allie",
                LastName = "Schwartz"
            };           

            _employee.Dependents.Add(dependent1);            

            //Act
            _employeeRepositoryMock.Setup(x => x.Get(1)).Returns(_employee);

            var employeeMapped = Mapper.Map<Employee, EmployeeViewModel>(_employee);

            //Assert
            Assert.AreEqual(1450M, employeeMapped.TotalBenefitCost);
        }

        [TestMethod]
        public void CalculateBenefitCosts_EmployeeWithTwoDependentsWithDiscount_ReturnsValidCost()
        {
            //Arrange
            _employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Mike",
                LastName = "Schwartz"
            };

            var dependent1 = new Dependent()
            {
                FirstName = "Allie",
                LastName = "Schwartz"
            };

            var dependent2 = new Dependent()
            {
                FirstName = "Adam",
                LastName = "Schwartz"
            };

            _employee.Dependents.Add(dependent1);
            _employee.Dependents.Add(dependent2);

            //Act
            _employeeRepositoryMock.Setup(x => x.Get(1)).Returns(_employee);

            var employeeMapped = Mapper.Map<Employee, EmployeeViewModel>(_employee);

            //Assert
            Assert.AreEqual(1900M, employeeMapped.TotalBenefitCost);
        }

    }
}
