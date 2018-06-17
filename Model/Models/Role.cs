using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
  public class Role
  {
    [Key]
    public Guid Id { get; set; }

    [MaxLength(32)]
    public string Name { get; set; }
  }
}