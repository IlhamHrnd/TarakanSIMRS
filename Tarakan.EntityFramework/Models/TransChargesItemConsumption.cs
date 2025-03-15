using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemConsumption
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string DetailItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal? QtyRealization { get; set; }

    public string SritemUnit { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? AveragePrice { get; set; }

    public decimal? FifoPrice { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsPackage { get; set; }

    public string? LocationId { get; set; }
}
