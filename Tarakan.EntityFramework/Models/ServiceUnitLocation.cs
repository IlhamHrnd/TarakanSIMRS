using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitLocation
{
    public string ServiceUnitId { get; set; }

    public string LocationId { get; set; }

    public bool? IsLocationMain { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
