using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeHealthAndSafety
{
    public string EmployeeHealthAndSafetyNo { get; set; } = null!;

    public string SremployerStatus { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public DateOnly? Birthdate { get; set; }

    public string? BirthPlace { get; set; }

    public string? SrgenderType { get; set; }

    public string? Address { get; set; }

    public string? Telp { get; set; }

    public string? DepartmentId { get; set; }

    public string JobTitle { get; set; } = null!;

    public string IncidentPlace { get; set; } = null!;

    public DateTime IncidentDateTime { get; set; }

    public DateTime ArriveInHospitalDateTime { get; set; }

    public DateTime? LeaveHospitalDateTime { get; set; }

    public string Chronology { get; set; } = null!;

    public string ChronologyEnvironmentInvolved { get; set; } = null!;

    public string SrincidentImpact { get; set; } = null!;

    public string? InjuryDetail { get; set; }

    public string? EnvironmentCost { get; set; }

    public string? ParamedicId { get; set; }

    public string? ConditionAfterFirstAid { get; set; }

    public string? SremployeeOutpatientTreatment { get; set; }

    public string? SremployeeTreatment { get; set; }

    public string? AdditionalInformation { get; set; }

    public string InsertByUserId { get; set; } = null!;

    public DateTime InsertDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
