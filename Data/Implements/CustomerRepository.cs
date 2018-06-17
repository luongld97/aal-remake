using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class CustomerRepository : Repository<Customer>, ICustomerRepository
  {
    public CustomerRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}