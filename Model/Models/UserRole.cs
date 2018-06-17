using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
  public class UserRole
  {
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
    public virtual Role Role { get; set; }
    public virtual User User { get; set; }
  }
}