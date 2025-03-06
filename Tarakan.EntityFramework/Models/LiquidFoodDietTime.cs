﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LiquidFoodDietTime
{
    public string DietId { get; set; }

    public string Time { get; set; }

    public string FoodId { get; set; }

    public string ChildrenFoodId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
