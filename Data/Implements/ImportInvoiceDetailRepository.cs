using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ImportInvoiceDetailRepository : Repository<ImportInvoiceDetail>, IImportInvoiceDetailRepository
  {
    public ImportInvoiceDetailRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}