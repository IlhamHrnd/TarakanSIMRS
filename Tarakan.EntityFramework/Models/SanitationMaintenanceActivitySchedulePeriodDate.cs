using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SanitationMaintenanceActivitySchedulePeriodDate
{
    public string SrworkTradeItem { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string PeriodYear { get; set; } = null!;

    public DateTime PeriodDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
