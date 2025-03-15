using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeEmploymentPeriod
{
    public int EmployeeEmploymentPeriodId { get; set; }

    public int PersonId { get; set; }

    public string SremploymentType { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public int? RecruitmentPlanId { get; set; }

    public string? SremploymentCategory { get; set; }

    public string? EmployeeNumber { get; set; }
}
