using EmployeeDeductions.Domain.Interfaces;
using EmployeeDeductions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDeductions.Domain.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
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
            employee.FirstName = "Michael";
            employee.LastName = "Schwartz";
            employee.EmployeeId = id;
            employee.Dependents.Add(dependent);
            employee.Dependents.Add(dependent2);

            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
