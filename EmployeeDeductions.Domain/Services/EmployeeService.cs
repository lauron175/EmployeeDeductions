using EmployeeDeductions.Domain.Interfaces;
using EmployeeDeductions.Domain.Models;
using System;
using System.Collections.Generic;

namespace EmployeeDeductions.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }        

        public void Create(Employee item)
        {
            _employeeRepository.Create(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            var employee = _employeeRepository.Get(id);

            return employee;
        }

        public List<Employee> GetAll()
        {
            var employees = _employeeRepository.GetAll();

            return employees;
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }

        public CalculatedBenefitCosts CalculateBenefitsCost(int employeeId)
        {            
            var employee = this.Get(employeeId);//first get the employee we are dealing with
            var calculatedBenefitCosts = new CalculatedBenefitCosts();

            if (employee.Dependents.Count < 1)
            {
                calculatedBenefitCosts.AnnualSalary = employee.Pay * 26;
                calculatedBenefitCosts.SalaryAfterDeductions = employee.Pay - employee.BenefitCost;
            }

            //var response = new CalculatedBenefitCosts();
            //response.AnnualSalary = 80000M;
            //response.SalaryAfterDeductions = 72000M;
            //response.TotalDeductions = 8000M;

            return calculatedBenefitCosts;
        }
    }
}
