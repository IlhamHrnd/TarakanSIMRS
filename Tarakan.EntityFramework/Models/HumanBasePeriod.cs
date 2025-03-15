using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HumanBasePeriod
{
    public int HumanBasePeriodId { get; set; }

    public string YearPeriod { get; set; } = null!;

    public string PeriodeName { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? IsRecruitment { get; set; }

    public bool? IsTraining { get; set; }

    public bool? IsCareer { get; set; }

    public bool? IsAppraisal { get; set; }

    public bool? IsMedical { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
