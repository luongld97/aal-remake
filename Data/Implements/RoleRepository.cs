using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class RoleRepository : Repository<Role>, IRoleRepository
  {
    public RoleRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}