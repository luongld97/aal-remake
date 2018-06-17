using Data.Repositories;
using Model.Models;

namespace Data.Implements
{
  public class ImportInvoiceRepository : Repository<ImportInvoice>, IImportInvoiceRepository
  {
    public ImportInvoiceRepository(AALDbContext dbContext) : base(dbContext)
    {
    }
  }
}