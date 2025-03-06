using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeNeedleStickInjury
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string ReferenceNo { get; set; }

    public string ExposedArea { get; set; }

    public string Reason { get; set; }

    public bool IsBlood { get; set; }

    public bool IsFluidSperm { get; set; }

    public bool IsVaginalSecretions { get; set; }

    public bool IsCerebrospinal { get; set; }

    public bool IsUrine { get; set; }

    public bool IsFaeces { get; set; }

    public bool IsOfficerHiv { get; set; }

    public bool IsOfficerHbv { get; set; }

    public bool IsOfficerHcv { get; set; }

    public string OfficerImunizationHistory { get; set; }

    public string Chronology { get; set; }

    public string Recomendation { get; set; }

    public string PatientId { get; set; }

    public string RegistrationNo { get; set; }

    public string Diagnose { get; set; }

    public bool IsPatientHiv { get; set; }

    public bool IsPatientHbv { get; set; }

    public bool IsPatientHcv { get; set; }

    public string PatientImunizationHistory { get; set; }

    public bool IsSpo { get; set; }

    public bool IsUsingApd { get; set; }

    public string KnownBy { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public string FollowUpNotes { get; set; }

    public string FollowUpBy { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string VerifiedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
