using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("ImportBills")]
  public class ImportBill
  {
    [Key]
    public Guid Id { get; set; }

    public Guid SupplierId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedDate { get; set; }

    [ForeignKey("SupplierId")]
    public virtual Supplier Supplier { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }

    public virtual List<ImportBillDetail> Details { get; set; }
  }
}