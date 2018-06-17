using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ImportBillDetailRepository : Repository<ImportBillDetail>, IImportBillDetailRepository
  {
    public ImportBillDetailRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}