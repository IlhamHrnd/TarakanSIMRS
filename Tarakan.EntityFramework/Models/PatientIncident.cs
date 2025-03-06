using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncident
{
    public string PatientIncidentNo { get; set; }

    public string RegistrationNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }

    public string IncidentLocation { get; set; }

    public string ServiceUnitIdinCharge { get; set; }

    public DateTime IncidentDateTime { get; set; }

    public DateTime ReportingDateTime { get; set; }

    public string IncidentName { get; set; }

    public string Chronology { get; set; }

    public string SrincidentType { get; set; }

    public string SrincidentGroup { get; set; }

    public string SrclinicalImpact { get; set; }

    public string SrincidentProbabilityFrequency { get; set; }

    public string Handling { get; set; }

    public string SrincidentHandledBy { get; set; }

    public string SrincidentFollowUp { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public string ReportedByUserId { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime InsertDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string SrincidentOccurredOn { get; set; }

    public string IncidentOccurredOnName { get; set; }

    public string SrincidentOccurredInPatientsWith { get; set; }

    public string IncidentOccurredInPatientsWithName { get; set; }

    public bool? IsOccurInOtherUnits { get; set; }

    public string OccurInOtherUnitsNotes { get; set; }

    public bool? IsApproved { get; set; }

    public string ApprovedByUserId { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string PatientId { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string Sex { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string Address { get; set; }

    public bool? NonPatient { get; set; }

    public bool? IsVerified { get; set; }

    public string VerifiedByUserId { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string ServiceUnitIncidentLocationId { get; set; }

    public string ParamedicId { get; set; }

    public bool? IsRiskManagement { get; set; }

    public string SrincidentGroupPrev { get; set; }

    public string SrclinicalImpactPrev { get; set; }

    public string SrincidentProbabilityFrequencyPrev { get; set; }

    public string SrincidentFollowUpPrev { get; set; }

    public string InitialName { get; set; }
}
