using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrderItem
{
    public string OrderNo { get; set; }

    public string SrmealSet { get; set; }

    public string FoodId { get; set; }

    public bool IsOptional { get; set; }

    public bool? IsCustom { get; set; }

    public string DietPatientNo { get; set; }

    public string DietId { get; set; }

    public string MenuId { get; set; }

    public string MenuItemId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
