using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("ImportInvoices")]
  public class ImportInvoice
  {
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid CreatedBy { get; set; }
    
    [ForeignKey("CreatedBy")]
    public virtual User User { get; set; }

    public virtual List<ImportInvoiceDetail> Details { get; set; }
  }
}