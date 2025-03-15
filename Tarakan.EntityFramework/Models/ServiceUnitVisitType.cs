using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitVisitType
{
    public string ServiceUnitId { get; set; } = null!;

    public string VisitTypeId { get; set; } = null!;

    public byte VisitDuration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
