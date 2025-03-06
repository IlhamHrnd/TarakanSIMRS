using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AveragePriceHistory
{
    public string TransactionNo { get; set; }

    public string ItemId { get; set; }

    public string ItemUnit { get; set; }

    public DateTime ChangedDate { get; set; }

    public string TransactionCode { get; set; }

    public decimal OldAveragePrice { get; set; }

    public decimal NewAveragePrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? OldPriceInBaseUnit { get; set; }

    public decimal? OldPriceInPurchaseUnit { get; set; }

    public decimal? OldPurchaseDiscount1 { get; set; }

    public decimal? OldPurchaseDiscount2 { get; set; }

    public decimal? NewPriceInBaseUnit { get; set; }

    public decimal? NewPriceInPurchaseUnit { get; set; }

    public decimal? NewPurchaseDiscount1 { get; set; }

    public decimal? NewPurchaseDiscount2 { get; set; }
}
