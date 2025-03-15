using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffRequestItem
{
    public string TariffRequestNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? PriceInBaseUnit { get; set; }

    public decimal? PriceInBaseUnitWvat { get; set; }

    public decimal? PriceInPurchaseUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public bool? IsAllowCito { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public decimal? CitoValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? DiscPercentage { get; set; }

    public bool? IsCitoFromStandardReference { get; set; }
}
