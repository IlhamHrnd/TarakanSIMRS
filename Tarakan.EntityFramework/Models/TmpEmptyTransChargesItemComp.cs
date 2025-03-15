using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpEmptyTransChargesItemComp
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string? ItemId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? ClassId { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public decimal? DiscountAmt { get; set; }

    public decimal? PriceAmt { get; set; }
}
