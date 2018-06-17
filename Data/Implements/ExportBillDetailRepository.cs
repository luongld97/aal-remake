using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ExportBillDetailRepository : Repository<ExportBillDetail>, IExportBillDetailRepository
  {
    public ExportBillDetailRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}