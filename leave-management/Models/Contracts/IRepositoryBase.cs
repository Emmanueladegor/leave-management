﻿using System;
using System.Collections.Generic;

namespace leave_management.Models.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();

        T FindById(int id);

        bool Create(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        bool Save();
    }
}
