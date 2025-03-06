using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RecruitmentPlan
{
    public int RecruitmentPlanId { get; set; }

    public string RecruitmentPlanName { get; set; }

    public int PositionId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public int NumberOfRequestedEmployees { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string Notes { get; set; }

    public int? OrganizationUnitId { get; set; }

    public int? DivisionId { get; set; }

    public int? SubDivisionId { get; set; }

    public int? SectionId { get; set; }
}
