using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class UserRepository : Repository<User>, IUserRepository
  {
    public UserRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}