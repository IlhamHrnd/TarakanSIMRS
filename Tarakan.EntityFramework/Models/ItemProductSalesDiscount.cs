using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductSalesDiscount
{
    public string SalesDiscId { get; set; } = null!;

    public string SritemType { get; set; } = null!;

    public decimal SupplierDiscPercentageFrom { get; set; }

    public decimal SupplierDiscPercentageTo { get; set; }

    public decimal SalesDiscPercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
