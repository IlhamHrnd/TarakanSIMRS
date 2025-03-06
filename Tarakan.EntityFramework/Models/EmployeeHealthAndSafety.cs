using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeHealthAndSafety
{
    public string EmployeeHealthAndSafetyNo { get; set; }

    public string SremployerStatus { get; set; }

    public string EmployeeId { get; set; }

    public string EmployeeName { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string BirthPlace { get; set; }

    public string SrgenderType { get; set; }

    public string Address { get; set; }

    public string Telp { get; set; }

    public string DepartmentId { get; set; }

    public string JobTitle { get; set; }

    public string IncidentPlace { get; set; }

    public DateTime IncidentDateTime { get; set; }

    public DateTime ArriveInHospitalDateTime { get; set; }

    public DateTime? LeaveHospitalDateTime { get; set; }

    public string Chronology { get; set; }

    public string ChronologyEnvironmentInvolved { get; set; }

    public string SrincidentImpact { get; set; }

    public string InjuryDetail { get; set; }

    public string EnvironmentCost { get; set; }

    public string ParamedicId { get; set; }

    public string ConditionAfterFirstAid { get; set; }

    public string SremployeeOutpatientTreatment { get; set; }

    public string SremployeeTreatment { get; set; }

    public string AdditionalInformation { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime InsertDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
