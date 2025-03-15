using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemBalanceEndOfTheMonth
{
    public DateOnly TransactionDate { get; set; }

    public string LocationId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Balance { get; set; }

    public string? SritemUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? PriceInBaseUnit { get; set; }

    public decimal? PriceInBasedUnitWvat { get; set; }

    public decimal? QtyUsagePerDay { get; set; }

    public decimal? QtyUsagePerMonth { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? PurchaseDiscount1 { get; set; }

    public decimal? PurchaseDiscount2 { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }

    public decimal? BalanceItemMovement { get; set; }
}
