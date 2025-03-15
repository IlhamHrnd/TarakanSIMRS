using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicSchedulePerDate
{
    public string ServiceUnitId { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string PeriodYear { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public short? QuotaOfflineBpjs { get; set; }

    public short? QuotaOfflineNonBpjs { get; set; }

    public short? QuotaOnlineBpjs { get; set; }

    public short? QuotaOnlineNonBpjs { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public byte? IsSetPrimary { get; set; }
}
