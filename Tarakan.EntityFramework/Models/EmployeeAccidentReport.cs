using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeAccidentReport
{
    public string TransactionNo { get; set; }

    public DateTime ReportingDateTime { get; set; }

    public DateTime IncidentDateTime { get; set; }

    public string IncidentLocation { get; set; }

    public int? SupervisorId { get; set; }

    public int PersonId { get; set; }

    public byte AgeInYear { get; set; }

    public byte AgeInMonth { get; set; }

    public byte AgeInDay { get; set; }

    public int PositionId { get; set; }

    public string SremployeeInjuryCategory { get; set; }

    public string SremployeeIncidentStatus { get; set; }

    public string ChronologicalEvents { get; set; }

    public string AspectsOfTheCause { get; set; }

    public string InjuredLocation { get; set; }

    public string PlaceOfTreatment { get; set; }

    public string SremployeeIncidentType { get; set; }

    public string SrneedleType { get; set; }

    public byte LossTime { get; set; }

    public string UnsafeCondition { get; set; }

    public string UnsafeAct { get; set; }

    public string PersonalIndirectCause { get; set; }

    public string WorkingIndirectCause { get; set; }

    public string ActionPlan { get; set; }

    public string Target { get; set; }

    public string Authority { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SremployeeAccidentReportStatus { get; set; }
}
