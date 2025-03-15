using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpParamedicSchedule
{
    public string? ServiceUnitId { get; set; }

    public string? ParamedicId { get; set; }

    public double? PeriodYear { get; set; }

    public double? ExamDuration { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
