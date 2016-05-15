﻿using System.Collections.Generic;

namespace EmployeeDeductions.Domain.Interfaces
{
    public interface IService<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
