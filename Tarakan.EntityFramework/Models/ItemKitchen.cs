using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemKitchen
{
    public string ItemId { get; set; } = null!;

    public string Abcclass { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string SrpurchaseUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public bool IsInventoryItem { get; set; }

    public bool IsControlExpired { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWvat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal LastPriceInBaseUnit { get; set; }

    public decimal PriceWvat { get; set; }

    public decimal CostPrice { get; set; }

    public decimal PurchaseDiscount1 { get; set; }

    public decimal PurchaseDiscount2 { get; set; }

    public decimal SafetyStock { get; set; }

    public byte SafetyTime { get; set; }

    public byte LeadTime { get; set; }

    public decimal TolerancePercentage { get; set; }

    public string Barcode { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsSalesAvailable { get; set; }

    public decimal? SalesFixedPrice { get; set; }

    public decimal? MarginPercentage { get; set; }

    public string? MarginId { get; set; }

    public virtual Item Item { get; set; } = null!;
}
