using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InventoryBalanceBak
{
    public DateOnly PeriodDate { get; set; }

    public string LocationId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal BeginningBalance { get; set; }

    public decimal InitialQuantity { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public decimal BalanceIn { get; set; }

    public decimal BalanceOut { get; set; }

    public decimal Balance { get; set; }

    public decimal CostPrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? LastQuantity { get; set; }

    public decimal? DiffQuantity { get; set; }
}
