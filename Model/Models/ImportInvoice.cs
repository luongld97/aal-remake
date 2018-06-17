using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
  public class ImportInvoice
  {
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid CreatedBy { get; set; }
  }
}