using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Food
{
    public string FoodId { get; set; }

    public string FoodName { get; set; }

    public string Notes { get; set; }

    public decimal Weight { get; set; }

    public string SritemUnit { get; set; }

    public decimal QtyPortion { get; set; }

    public string SrfoodGroup1 { get; set; }

    public string SrfoodGroup2 { get; set; }

    public bool? IsForSpecialCondition { get; set; }

    public bool? IsSalesAvailable { get; set; }

    public string ItemId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsPackage { get; set; }
}
