using System;
using System.Collections.Generic;

namespace Data.Repositories
{
  public interface IRepository<T> where T : class
  {
    List<T> GetAll();
    List<T> Get(Func<T, bool> predicate);
    T Get(object id);
    bool Create(T entity);
    bool Update(T entity);
    bool Delete(T entity);
    int Count(Func<T, bool> predicate);
  }
}