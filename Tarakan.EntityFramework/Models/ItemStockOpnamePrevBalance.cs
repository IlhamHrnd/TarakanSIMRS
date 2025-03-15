using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemStockOpnamePrevBalance
{
    public string TransactionNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string SritemUnit { get; set; } = null!;

    public decimal? CostPrice { get; set; }

    public decimal? QtyAtApprove { get; set; }
}
