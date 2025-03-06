using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicScheduleForWebsite
{
    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public bool? IsMonday { get; set; }

    public bool? IsTuesday { get; set; }

    public bool? IsWednesday { get; set; }

    public bool? IsThursday { get; set; }

    public bool? IsFriday { get; set; }

    public bool? IsSaturday { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string Image { get; set; }

    public bool? IsMondayCendana { get; set; }

    public bool? IsTuesdayCendana { get; set; }

    public bool? IsWednesdayCendana { get; set; }

    public bool? IsThursdayCendana { get; set; }

    public bool? IsFridayCendana { get; set; }

    public bool? IsSaturdayCendana { get; set; }

    public int? QuotaOnlineBpjs { get; set; }

    public int? QuotaOnlineCendana { get; set; }

    public string ServiceUnitIdcendana { get; set; }

    public int? QuotaOnsiteBpjs { get; set; }

    public int? QuotaOnsiteCendana { get; set; }

    public int? RemainingQuotaOnlineBpjs { get; set; }

    public int? RemainingQuotaOnlineCendana { get; set; }

    public int? RemainingQuotaOnsiteBpjs { get; set; }

    public int? RemainingQuotaOnsiteCendana { get; set; }
}
