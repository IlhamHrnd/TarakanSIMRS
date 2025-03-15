using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonnelRequisition
{
    public int PersonnelRequisitionId { get; set; }

    public int RequestedByPersonId { get; set; }

    public int NumberOfRequiredEmployee { get; set; }

    public string SrrequestStatus { get; set; } = null!;

    public int RecruitmentPlanId { get; set; }

    public int OrganizationUnitId { get; set; }

    public string SrpreferredSource { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string? Reason { get; set; }

    public string? MiscellaneousSpec { get; set; }

    public string SremploymentType { get; set; } = null!;

    public int? ProbationMonth { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
