using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemOptic
{
    public string ItemId { get; set; } = null!;

    public string? MarginId { get; set; }

    public string SrproductType { get; set; } = null!;

    public string Abcclass { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string SrpurchaseUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public bool IsInventoryItem { get; set; }

    public string? FabricId { get; set; }

    public decimal SalesFixedPrice { get; set; }

    public decimal MarginPercentage { get; set; }

    public decimal SalesDiscount { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWvat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal CostPrice { get; set; }

    public decimal TolerancePercentage { get; set; }

    public string Barcode { get; set; } = null!;

    public string SritemBin { get; set; } = null!;

    public bool? IsConsignment { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual Item Item { get; set; } = null!;
}
