using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClassMenuSetting
{
    public string ClassId { get; set; }

    public bool IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
