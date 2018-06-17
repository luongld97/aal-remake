using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ImportBillRepository : Repository<ImportBill>, IImportBillRepository
  {
    public ImportBillRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}