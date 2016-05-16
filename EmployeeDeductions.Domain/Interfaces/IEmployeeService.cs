using EmployeeDeductions.Domain.Models;
using System.Collections.Generic;

namespace EmployeeDeductions.Domain.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee Get(int id);
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(int id);        
        CalculatedBenefitCosts CalculateBenefitsCost(int employeeId);
    }
}
