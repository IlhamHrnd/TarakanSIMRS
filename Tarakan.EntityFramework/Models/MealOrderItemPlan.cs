using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrderItemPlan
{
    public string OrderNo { get; set; }

    public DateTime? OrderToDate { get; set; }

    public string SrmealSet { get; set; }

    public string FoodId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
