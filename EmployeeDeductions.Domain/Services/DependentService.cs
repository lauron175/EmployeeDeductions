using EmployeeDeductions.Domain.Interfaces;
using System;
using System.Collections.Generic;
using EmployeeDeductions.Domain.Models;

namespace EmployeeDeductions.Domain.Services
{
    public class DependentService : IDependentService
    {
        private IRepository<Dependent> _dependentRepository;

        public DependentService(IRepository<Dependent> dependentRepository)
        {
            _dependentRepository = dependentRepository;
        }

        public void Create(Dependent dependent)
        {
            _dependentRepository.Create(dependent);
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

        public void Update(Dependent dependent)
        {
            throw new NotImplementedException();
        }
    }
}
