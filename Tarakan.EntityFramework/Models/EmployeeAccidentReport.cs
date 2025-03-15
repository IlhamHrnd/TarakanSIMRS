using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeAccidentReport
{
    public string TransactionNo { get; set; } = null!;

    public DateTime ReportingDateTime { get; set; }

    public DateTime IncidentDateTime { get; set; }

    public string IncidentLocation { get; set; } = null!;

    public int? SupervisorId { get; set; }

    public int PersonId { get; set; }

    public byte AgeInYear { get; set; }

    public byte AgeInMonth { get; set; }

    public byte AgeInDay { get; set; }

    public int PositionId { get; set; }

    public string SremployeeInjuryCategory { get; set; } = null!;

    public string SremployeeIncidentStatus { get; set; } = null!;

    public string ChronologicalEvents { get; set; } = null!;

    public string AspectsOfTheCause { get; set; } = null!;

    public string InjuredLocation { get; set; } = null!;

    public string PlaceOfTreatment { get; set; } = null!;

    public string SremployeeIncidentType { get; set; } = null!;

    public string? SrneedleType { get; set; }

    public byte LossTime { get; set; }

    public string UnsafeCondition { get; set; } = null!;

    public string UnsafeAct { get; set; } = null!;

    public string PersonalIndirectCause { get; set; } = null!;

    public string WorkingIndirectCause { get; set; } = null!;

    public string ActionPlan { get; set; } = null!;

    public string Target { get; set; } = null!;

    public string Authority { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SremployeeAccidentReportStatus { get; set; }
}
