using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VisitsPerServiceUnitPerPeriod
{
    public string ServiceUnitId { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string Year { get; set; } = null!;

    public long TotalVisit { get; set; }

    public DateTime? LastCreatedDateTime { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
