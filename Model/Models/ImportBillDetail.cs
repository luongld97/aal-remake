using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("ImportBillDetails")]
  public class ImportBillDetail
  {
    [Key]
    public Guid Id { get; set; }


    public Guid BillId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    [ForeignKey("BillId")]
    public virtual ImportBill Bill { get; set; }

    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; }
  }
}