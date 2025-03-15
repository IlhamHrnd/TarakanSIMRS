using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietLiquidPatientItem
{
    public string TransactionNo { get; set; } = null!;

    public string DietTime { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal? Qty { get; set; }

    public string? SritemUnit { get; set; }

    public string? Notes { get; set; }

    public string? FoodId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
