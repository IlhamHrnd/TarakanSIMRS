using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemMovement
{
    public Guid MovementId { get; set; }

    public DateTime MovementDate { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public DateTime? ExpiredDate { get; set; }

    public decimal? InitialStock { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public string SritemUnit { get; set; } = null!;

    public decimal CostPrice { get; set; }

    public decimal SalesPrice { get; set; }

    public decimal PurchasePrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }
}
