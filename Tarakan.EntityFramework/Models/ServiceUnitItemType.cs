using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitItemType
{
    public string ServiceUnitId { get; set; }

    public string SritemType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
