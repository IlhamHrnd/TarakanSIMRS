using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuItemFood
{
    public string MenuItemId { get; set; }

    public string SrmealSet { get; set; }

    public string FoodId { get; set; }

    public string SrmenuItemFoodGroup { get; set; }

    public bool IsOptional { get; set; }

    public bool? IsStandard { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
