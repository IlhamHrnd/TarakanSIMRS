using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTransactionItemHistory
{
    public string TransactionNo { get; set; }

    public string LocationId { get; set; }

    public string ItemId { get; set; }

    public string ReferenceNo { get; set; }

    public DateTime BalanceDate { get; set; }

    public decimal Balance { get; set; }

    public decimal Price { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }
}
