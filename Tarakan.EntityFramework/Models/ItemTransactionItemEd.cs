using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTransactionItemEd
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public DateTime ExpiredDate { get; set; }

    public string BatchNumber { get; set; } = null!;

    public string? ItemId { get; set; }

    public decimal? Quantity { get; set; }

    public string? SritemUnit { get; set; }

    public decimal? ConversionFactor { get; set; }

    public decimal? QuantityFinishInBaseUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? ClosedDateTime { get; set; }

    public string? ClosedByUserId { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }
}
