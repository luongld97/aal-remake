using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
  {
    public WarehouseRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}