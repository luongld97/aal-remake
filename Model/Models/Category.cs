using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("Categories")]
  public class Category
  {
    [Key]
    public Guid Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    public Guid ParentId { get; set; }
    
    [ForeignKey("ParentId")]
    public virtual Category Parent { get; set; }

    public virtual List<Product> Products { get; set; }
  }
}