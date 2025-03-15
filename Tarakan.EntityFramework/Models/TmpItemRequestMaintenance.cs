using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpItemRequestMaintenance
{
    public string UserId { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public string ToServiceUnitId { get; set; } = null!;

    public string FollowUpId { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public string? SritemUnit { get; set; }

    public decimal? ConversionFactor { get; set; }
}
