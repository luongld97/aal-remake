using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ExportInvoiceDetailRepository : Repository<ExportInvoiceDetail>, IExportInvoiceDetailRepository
  {
    public ExportInvoiceDetailRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}