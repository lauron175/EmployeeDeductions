using EmployeeDeductions.Domain.Interfaces;
using EmployeeDeductions.Domain.Models;
using System;
using System.Collections.Generic;

namespace EmployeeDeductions.Domain.Services
{
    public class EmployeeService : IService<Employee>
    {
        private IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void Create(Employee item)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
