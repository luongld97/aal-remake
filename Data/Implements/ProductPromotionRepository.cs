using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ProductPromotionRepository : Repository<ProductPromotion>, IProductPromotionRepository
  {
    public ProductPromotionRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}