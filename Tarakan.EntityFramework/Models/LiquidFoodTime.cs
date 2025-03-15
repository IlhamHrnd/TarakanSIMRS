using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LiquidFoodTime
{
    public string StandardReferenceId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string FoodId { get; set; } = null!;

    public string? ChildrenFoodId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
