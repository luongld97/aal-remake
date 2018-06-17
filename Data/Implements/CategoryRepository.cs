using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class CategoryRepository : Repository<Category>, ICategoryRepository
  {
    public CategoryRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}