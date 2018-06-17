using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("Promotion")]
  public class Promotion
  {
    [Key]
    public Guid Id { get; set; }

    public bool Active { get; set; }

    [MaxLength(150)]
    public string Title { get; set; }

    public int Type { get; set; }
    public decimal Discount { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    [MaxLength(1)]
    public int Level { get; set; }

    public virtual List<ProductPromotion> ProductPromotions { get; set; }
  }
}