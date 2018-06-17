using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("ExportInvoiceDetails")]
  public class ExportInvoiceDetail
  {
    [Key]
    public Guid Id { get; set; }

    public Guid InvoiceId { get; set; }
    public Guid ProductId { get; set; }
    public Guid WarehouseId { get; set; }
    public int Quantity { get; set; }

    [ForeignKey("InvoiceId")]
    public virtual ExportInvoice ExportInvoice { get; set; }

    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; }

    [ForeignKey("WarehouseId")]
    public virtual Warehouse Warehouse { get; set; }
  }
}