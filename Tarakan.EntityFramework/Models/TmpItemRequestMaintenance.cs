using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpItemRequestMaintenance
{
    public string UserId { get; set; }

    public DateTime TransDate { get; set; }

    public string ToServiceUnitId { get; set; }

    public string FollowUpId { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public decimal? Quantity { get; set; }

    public string SritemUnit { get; set; }

    public decimal? ConversionFactor { get; set; }
}
