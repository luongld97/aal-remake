using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("Products")]
  public class Product
  {
    [Key]
    public Guid Id { get; set; }

    [MaxLength(255)]
    public string Name { get; set; }

    public bool Active { get; set; }
    public decimal DefaultPrice { get; set; }

    [MaxLength(2000)]
    public string Description { get; set; }

    public Guid CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public virtual Category Category { get; set; }

    public virtual List<WarehouseDetail> WarehouseDetails { get; set; }
    public virtual List<ImportInvoiceDetail> ImportInvoiceDetails { get; set; }
    public virtual List<ExportInvoiceDetail> ExportInvoiceDetails { get; set; }
    public virtual List<ExportBillDetail> ExportBillDetails { get; set; }
    public virtual List<ImportBillDetail> ImportBillDetails { get; set; }
    public virtual List<ProductRate> Rates { get; set; }
    public virtual List<ProductPromotion> ProductPromotions { get; set; }
  }
}