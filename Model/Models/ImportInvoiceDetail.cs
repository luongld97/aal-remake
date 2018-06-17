using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  public class ImportInvoiceDetail
  {
    [Key]
    public Guid Id { get; set; }

    public Guid InvoiceId { get; set; }
    
    [ForeignKey("InvoiceId")]
    public virtual ImportInvoice ImportInvoice { get; set; }

    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; }

    public Guid WarehouseId { get; set; }
    
    [ForeignKey("WarehouseId")]
    public virtual Warehouse Warehouse { get; set; }

    public int Quantity { get; set; }
  }
}