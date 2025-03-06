using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemBalanceDetail
{
    public string LocationId { get; set; }

    public string ItemId { get; set; }

    public string ReferenceNo { get; set; }

    public string TransactionCode { get; set; }

    public DateTime BalanceDate { get; set; }

    public decimal Balance { get; set; }

    public decimal Booking { get; set; }

    public decimal Price { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string PurchaseReceiveNo { get; set; }
}
