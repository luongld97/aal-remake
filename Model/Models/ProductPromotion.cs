using System;

namespace Model.Models
{
  public class ProductPromotion
  {
    public Guid ProductId { get; set; }
    public Guid PromotionId { get; set; }
    public virtual Product Product { get; set; }
    public virtual Promotion Promotion { get; set; }
  }
}