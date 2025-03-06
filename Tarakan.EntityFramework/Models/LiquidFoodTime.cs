using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LiquidFoodTime
{
    public string StandardReferenceId { get; set; }

    public string ItemId { get; set; }

    public string Time { get; set; }

    public string FoodId { get; set; }

    public string ChildrenFoodId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
