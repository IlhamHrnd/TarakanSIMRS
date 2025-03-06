using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetWorkOrderItem
{
    public string OrderNo { get; set; }

    public string SeqNo { get; set; }

    public bool IsMasterItem { get; set; }

    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public decimal Quantity { get; set; }

    public decimal? QuantityRealization { get; set; }

    public string SritemUnit { get; set; }

    public decimal ConversionFactor { get; set; }

    public decimal CostPrice { get; set; }

    public decimal? Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsGeneratePrDr { get; set; }

    public string Specification { get; set; }

    public bool? IsGenerateIr { get; set; }
}
