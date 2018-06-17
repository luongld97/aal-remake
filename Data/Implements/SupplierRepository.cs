using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class SupplierRepository : Repository<Supplier>, ISupplierRepository
  {
    public SupplierRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}