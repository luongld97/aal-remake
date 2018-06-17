using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("ExportBills")]
  public class ExportBill
  {
    [Key]
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedDate { get; set; }

    [ForeignKey("CustomerId")]
    public virtual Customer Customer { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }

    public virtual List<ExportBillDetail> Details { get; set; }
  }
}