using MultiDataSourceGenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MultiDataSourceGenericRepository.Interfaces
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        T GetById(int id);
        T GetOne(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
