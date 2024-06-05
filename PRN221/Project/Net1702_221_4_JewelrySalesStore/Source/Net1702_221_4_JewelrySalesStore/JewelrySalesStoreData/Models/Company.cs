using System;
using System.Collections.Generic;

namespace JewelrySalesStoreData.Models;

public partial class Company
{
    public Guid CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CompanyDescription { get; set; }

    public string? CompanyPhone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
