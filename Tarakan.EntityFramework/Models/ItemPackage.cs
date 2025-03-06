using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemPackage
{
    public string ItemId { get; set; }

    public string DetailItemId { get; set; }

    public string ServiceUnitId { get; set; }

    public decimal Quantity { get; set; }

    public string SritemUnit { get; set; }

    public bool IsStockControl { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsExtraItem { get; set; }

    public decimal? DiscountValue { get; set; }

    public bool? IsDiscountInPercent { get; set; }

    public bool? IsAutoApprove { get; set; }
}
