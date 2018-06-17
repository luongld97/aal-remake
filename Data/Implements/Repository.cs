using System;
using System.Collections.Generic;
using System.Linq;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements
{
  public class Repository<T> : IRepository<T> where T : class
  {
    private readonly AALDbContext _dbContext;
    
    public Repository(AALDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public List<T> GetAll() => _dbContext.Set<T>().ToList();

    public List<T> Get(Func<T, bool> predicate) => _dbContext.Set<T>().Where(predicate).ToList();

    public T Get(object id) => _dbContext.Set<T>().Find(id);

    public bool Create(T entity)
    {
      _dbContext.Add(entity);
      return Save();
    }

    public bool Update(T entity)
    {
      _dbContext.Entry(entity).State = EntityState.Modified;
      return Save();
    }

    public bool Delete(T entity)
    {
      _dbContext.Remove(entity);
      return Save();
    }

    public int Count(Func<T, bool> predicate) => _dbContext.Set<T>().Count(predicate);

    private bool Save() =>_dbContext.SaveChanges() > 0;
  }
}