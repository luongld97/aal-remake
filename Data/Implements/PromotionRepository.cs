using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class PromotionRepository : Repository<Promotion>, IPromotionRepository
  {
    public PromotionRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}