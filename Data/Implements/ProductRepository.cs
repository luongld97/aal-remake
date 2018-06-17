using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ProductRepository : Repository<Product>, IProductRepository
  {
    public ProductRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}