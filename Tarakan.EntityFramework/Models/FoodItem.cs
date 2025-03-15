using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class FoodItem
{
    public string FoodId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public string? SritemUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
