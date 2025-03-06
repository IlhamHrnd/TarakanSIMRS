using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrderItemLiquid
{
    public string OrderNo { get; set; }

    public string MealTime { get; set; }

    public string FoodId { get; set; }

    public string DietLiquidTransNo { get; set; }

    public bool? IsDistributed { get; set; }

    public bool? IsVoidDistributed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
