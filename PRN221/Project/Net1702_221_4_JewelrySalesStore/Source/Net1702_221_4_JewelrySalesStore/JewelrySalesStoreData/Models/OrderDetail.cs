using System;
using System.Collections.Generic;

namespace JewelrySalesStoreData.Models;

public partial class OrderDetail
{
    public string OrderDetailId { get; set; } = null!;

    public Guid? OrderId { get; set; }

    public int? Quantity { get; set; }

    public Guid? ProductId { get; set; }

    public double? UnitPrice { get; set; }

    public double? TotalPrice { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
