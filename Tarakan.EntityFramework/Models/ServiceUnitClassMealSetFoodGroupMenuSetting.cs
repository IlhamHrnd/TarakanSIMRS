using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitClassMealSetFoodGroupMenuSetting
{
    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string SrmealSet { get; set; }

    public string SrfoodGroup1 { get; set; }

    public bool? IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
