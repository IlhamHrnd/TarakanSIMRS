using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrderItemPlan
{
    public string OrderNo { get; set; } = null!;

    public DateTime? OrderToDate { get; set; }

    public string SrmealSet { get; set; } = null!;

    public string FoodId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
