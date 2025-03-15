using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LiquidFoodDietTimeGender
{
    public string DietId { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string FoodId { get; set; } = null!;

    public string ChildrenFoodId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
