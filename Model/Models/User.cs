using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
  [Table("Roles")]
  public class User
  {
    [Key]
    public Guid Id { get; set; }

    [MaxLength(32)]
    public string Username { get; set; }
    
    [MaxLength(255)]
    public string Password { get; set; }
    public bool Active { get; set; }
    
    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [MaxLength(50)]
    public string LastName { get; set; }
    
    [MaxLength(150)]
    public string Address { get; set; }
    
    [MaxLength(150)]
    public string Email { get; set; }
    
    [MaxLength(20)]
    public string Phone { get; set; }
    
    public virtual List<UserRole> UserRoles { get; set; }
  }
}