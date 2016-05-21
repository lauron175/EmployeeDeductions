using EmployeeDeductions.Domain.Interfaces;
using EmployeeDeductions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDeductions.Domain.Repositories
{
    //Normally would not be mixing HttpContext into the domain project - just using the context as a temp db example
    public class EmployeeRepository : IRepository<Employee>
    {        
        public void Create(Employee item)
        {
            var currentEmployeeList = (List<Employee>)HttpContext.Current.Application["tempEmployees"];
            
            var lastEmployeeId = (from e in currentEmployeeList
                                 orderby e.EmployeeId descending
                                 select e.EmployeeId).FirstOrDefault();

            //faking out auto-increment on db
            item.EmployeeId = lastEmployeeId + 1;

            currentEmployeeList.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {

            var currentEmployeeList = (List<Employee>)HttpContext.Current.Application["tempEmployees"];

            var employee = (from e in currentEmployeeList
                            where e.EmployeeId == id                                  
                            select e).FirstOrDefault();
       
            return employee;
        }

        public List<Employee> GetAll()
        {            
            //Clearly this is not the way to do this - this is only for temporary data storage
            var employees = (List<Employee>) HttpContext.Current.Application["tempEmployees"];

            return employees;
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
