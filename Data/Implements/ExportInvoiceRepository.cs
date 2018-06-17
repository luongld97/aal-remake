using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ExportInvoiceRepository : Repository<ExportInvoice>, IExportInvoiceRepository
  {
    public ExportInvoiceRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}