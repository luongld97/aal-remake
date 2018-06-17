using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("Warehouses")]
  public class Warehouse
  {
    [Key]
    public Guid Id { get; set; }

    public bool Active { get; set; }
    public bool Full { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(150)]
    public string Address { get; set; }

    public virtual List<WarehouseDetail> Details { get; set; }
    public virtual List<ImportInvoiceDetail> ImportInvoiceDetails { get; set; }
    public virtual List<ExportInvoiceDetail> ExportInvoiceDetails { get; set; }
  }
}