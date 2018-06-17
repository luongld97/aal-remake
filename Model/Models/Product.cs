using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
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
  }
}