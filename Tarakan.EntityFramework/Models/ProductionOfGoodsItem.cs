using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ProductionOfGoodsItem
{
    public string ProductionNo { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; }

    public decimal CostPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? PriceInBaseUnit { get; set; }

    public bool? IsConsumables { get; set; }
}
