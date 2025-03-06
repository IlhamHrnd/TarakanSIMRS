using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductLog
{
    public string TariffRequestNo { get; set; }

    public string ItemId { get; set; }

    public decimal PriceInPurchaseUnitOld { get; set; }

    public decimal PriceInPurchaseUnitNew { get; set; }

    public decimal PriceInBaseUnitOld { get; set; }

    public decimal PriceInBaseUnitNew { get; set; }

    public decimal PriceInBaseUnitWvatOld { get; set; }

    public decimal PriceInBaseUnitWvatNew { get; set; }

    public decimal CostPriceOld { get; set; }

    public decimal CostPriceNew { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? SalesDiscountOld { get; set; }

    public decimal? SaledDiscountNew { get; set; }
}
