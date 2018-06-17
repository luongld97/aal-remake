using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class WarehouseDetailRepository : Repository<WarehouseDetail>, IWarehouseDetailRepository
  {
    public WarehouseDetailRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}