using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ProductRateRepository : Repository<ProductRate>, IProductRateRepository
  {
    public ProductRateRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}