using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  
  [Table("ProductRates")]
  public class ProductRate
  {
    
    [Key]
    public Guid Id { get; set; }

    [MaxLength(15)]
    public string ApplyDate { get; set; }

    public bool IncludedTax { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Guid ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; }
    
  }
}