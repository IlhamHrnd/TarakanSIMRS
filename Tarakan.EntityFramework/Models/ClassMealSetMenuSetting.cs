using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClassMealSetMenuSetting
{
    public string ClassId { get; set; } = null!;

    public string SrmealSet { get; set; } = null!;

    public bool IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
