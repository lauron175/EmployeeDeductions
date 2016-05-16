using EmployeeDeductions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDeductions.Domain.Interfaces
{
    public interface IDependentService
    {
        List<Dependent> GetAll();
        Dependent Get(int id);
        void Create(Dependent dependent);
        void Update(Dependent dependent);
        void Delete(int id);
    }
}
