using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("Roles")]
  public class Role
  {
    [Key]
    public Guid Id { get; set; }

    [MaxLength(32)]
    public string Name { get; set; }

    public virtual List<UserRole> UserRoles { get; set; }
  }
}