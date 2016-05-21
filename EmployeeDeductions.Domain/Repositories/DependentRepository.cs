using EmployeeDeductions.Domain.Interfaces;
using EmployeeDeductions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Web;

namespace EmployeeDeductions.Domain.Repositories
{
    //Normally would not be mixing HttpContext into the domain project - just using the context as a temp db example
    public class DependentRepository : IRepository<Dependent>
    {
        public void Create(Dependent item)
        {
            var currentEmployeeList = (List<Employee>)HttpContext.Current.Application["tempEmployees"];

            foreach (var employee in currentEmployeeList)
            {
                if (employee.EmployeeId == item.EmployeeId)
                {
                    employee.Dependents.Add(item);
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Dependent Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dependent> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Dependent item)
        {
            throw new NotImplementedException();
        }
    }
}
