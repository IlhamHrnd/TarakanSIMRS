using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicSchedule
{
    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public string PeriodYear { get; set; }

    public int? ExamDuration { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public short? Quota { get; set; }

    public short? QuotaOnline { get; set; }

    public short? QuotaBpjs { get; set; }

    public short? QuotaBpjsOnline { get; set; }

    public string PeriodMonth { get; set; }

    public virtual Paramedic Paramedic { get; set; }
}
