using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ProductionOfGoodsItem
{
    public string ProductionNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; } = null!;

    public decimal CostPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? PriceInBaseUnit { get; set; }

    public bool? IsConsumables { get; set; }
}
