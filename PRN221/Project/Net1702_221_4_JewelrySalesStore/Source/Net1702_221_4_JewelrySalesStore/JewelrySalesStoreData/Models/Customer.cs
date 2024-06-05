using System;
using System.Collections.Generic;

namespace JewelrySalesStoreData.Models;

public partial class Customer
{
    public Guid CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public DateTime CustomerBirthDate { get; set; }

    public string CustomerPhone { get; set; } = null!;

    public string CustomerAddress { get; set; } = null!;

    public double? CustomerPoint { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
