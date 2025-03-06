using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SanitationMaintenanceActivitySchedulePeriod
{
    public string SrworkTradeItem { get; set; }

    public string ServiceUnitId { get; set; }

    public string PeriodYear { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
