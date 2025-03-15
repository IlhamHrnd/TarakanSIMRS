using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemBalanceByPeriod
{
    public string LocationId { get; set; } = null!;

    public int PeriodYear { get; set; }

    public int PeriodMonth { get; set; }

    public string ItemId { get; set; } = null!;

    public decimal BeginningBalance { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public decimal AdjustmentIn { get; set; }

    public decimal AdjustmentOut { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
