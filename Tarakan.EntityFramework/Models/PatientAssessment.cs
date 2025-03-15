using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientAssessment
{
    public string RegistrationInfoMedicId { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string SrassessmentType { get; set; } = null!;

    public DateTime AssessmentDateTime { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public bool IsAutoAnamnesis { get; set; }

    public string? AllowAnamnesisSource { get; set; }

    public string? Hpi { get; set; }

    public string? Medikamentosa { get; set; }

    public string? ReviewOfSystem { get; set; }

    public string? PhysicalExam { get; set; }

    public string? OtherExam { get; set; }

    public string? Diagnose { get; set; }

    public string? Therapy { get; set; }

    public string? Education { get; set; }

    public byte[]? Genogram { get; set; }

    public string? Notes { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? AnamnesisNotes { get; set; }

    public bool? IsInitialAssessment { get; set; }

    public int? EstimatedDayInPatient { get; set; }

    public string? Prognosis { get; set; }

    public string? FollowUpPlanType { get; set; }

    public string? ConsulToType { get; set; }

    public string? ConsulTo { get; set; }

    public string? InpatientIndication { get; set; }

    public string? ControlPlan { get; set; }

    public string? JobHistNotes { get; set; }

    public string? HighRiskCriteria { get; set; }

    public DateTime? ConsultDate { get; set; }

    public string? ReferToHospital { get; set; }

    public string? ReferToFamilyDoctor { get; set; }

    public string? RoomInPatient { get; set; }

    public string? DpjpInPatient { get; set; }

    public bool? IsInPatientGuide { get; set; }

    public int? PatientEducationSeqNo { get; set; }

    public DateTime? DischargeDatePlan { get; set; }

    public string? DischargeMedicalPlan { get; set; }

    public DateTime? DoaDateTime { get; set; }

    public DateTime? SurgicalDateTime { get; set; }

    public string? InPatientRejectReason { get; set; }

    public string? ReferReason { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? Photo { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? DpjpInPatientId { get; set; }

    public byte[]? SignImg { get; set; }

    public byte[]? PatientSignImg { get; set; }
}
