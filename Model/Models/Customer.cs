using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("Customers")]
  public class Customer
  {
    [Key]
    public Guid Id { get; set; }

    [MaxLength(150)]
    public string Name { get; set; }
    
    [MaxLength(150)]
    public string Address { get; set; }
    
    [MaxLength(150)]
    public string Email { get; set; }
    
    [MaxLength(20)]
    public string Phone { get; set; }
    
    
  }
}