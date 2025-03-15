using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialProcess
{
    public string TransactionNo { get; set; } = null!;

    public string QuestionFormId { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public int PersonId { get; set; }

    public string? SremploymentType { get; set; }

    public string SrprofessionGroup { get; set; } = null!;

    public string SrclinicalWorkArea { get; set; } = null!;

    public string SrclinicalAuthorityLevel { get; set; } = null!;

    public int QuestionnaireId { get; set; }

    public string? SreducationLevel { get; set; }

    public string? InstitutionName { get; set; }

    public string? DiplomaNumber { get; set; }

    public DateTime? DiplomaDate { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? CompetencyAssessmentVerificationDate { get; set; }

    public int? CompetencyAssessmentVerificationBy { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserId { get; set; }

    public DateTime? CompetencyAssessmentVerificationDate2 { get; set; }

    public int? CompetencyAssessmentVerificationBy2 { get; set; }

    public bool? IsVerified2 { get; set; }

    public DateTime? VerifiedDateTime2 { get; set; }

    public string? VerifiedByUserId2 { get; set; }

    public bool? IsCompletelyVerified { get; set; }

    public DateTime? CredentialApplicationDate { get; set; }

    public string? ServiceUnitId { get; set; }

    public int? PositionId { get; set; }

    public string SrcredentialingStatus { get; set; } = null!;

    public string SrrecredentialReason { get; set; } = null!;

    public bool? IsCredentialApplication { get; set; }

    public DateTime? LastCredentialApplicationDateTime { get; set; }

    public string? LastCredentialApplicationByUserId { get; set; }

    public DateTime? CredentialingDate { get; set; }

    public bool? IsCertificateVerification { get; set; }

    public string? RecommendationNotes { get; set; }

    public bool? IsPerform { get; set; }

    public bool? IsCredentialing { get; set; }

    public DateTime? LastCredentialingDateTime { get; set; }

    public string? LastCredentialingByUserId { get; set; }

    public bool? IsReprocess { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime? RecommendationLetterDate { get; set; }

    public string? RecommendationLetterNo { get; set; }

    public bool? IsRecommendationLetter { get; set; }

    public DateTime? LastRecommendationLetterDateTime { get; set; }

    public string? LastRecommendationLetterByUserId { get; set; }

    public DateTime? ClinicalAssignmentLetterDate { get; set; }

    public string? DecreeNo { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public bool? IsClinicalAssignmentLetter { get; set; }

    public DateTime? LastClinicalAssignmentLetterDateTime { get; set; }

    public string? LastClinicalAssignmentLetterByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
