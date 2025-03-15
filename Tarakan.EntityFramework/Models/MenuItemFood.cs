using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuItemFood
{
    public string MenuItemId { get; set; } = null!;

    public string SrmealSet { get; set; } = null!;

    public string FoodId { get; set; } = null!;

    public string SrmenuItemFoodGroup { get; set; } = null!;

    public bool IsOptional { get; set; }

    public bool? IsStandard { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
