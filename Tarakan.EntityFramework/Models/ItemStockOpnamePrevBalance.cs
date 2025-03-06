using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemStockOpnamePrevBalance
{
    public string TransactionNo { get; set; }

    public string ItemId { get; set; }

    public decimal Quantity { get; set; }

    public string SritemUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? QtyAtApprove { get; set; }
}
