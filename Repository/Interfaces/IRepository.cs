﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> expression);

        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
