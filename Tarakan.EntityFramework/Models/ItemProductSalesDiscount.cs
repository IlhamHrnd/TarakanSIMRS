using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductSalesDiscount
{
    public string SalesDiscId { get; set; }

    public string SritemType { get; set; }

    public decimal SupplierDiscPercentageFrom { get; set; }

    public decimal SupplierDiscPercentageTo { get; set; }

    public decimal SalesDiscPercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
