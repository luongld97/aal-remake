using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ExportBillRepository : Repository<ExportBill>, IExportBillRepository
  {
    public ExportBillRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}