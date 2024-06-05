using System;
using System.Collections.Generic;

namespace JewelrySalesStoreData.Models;

public partial class Promotion
{
    public Guid PromotionId { get; set; }

    public string? PromotionName { get; set; }

    public double? DiscountPercentage { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
