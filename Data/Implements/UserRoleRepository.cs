using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
  {
    public UserRoleRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}