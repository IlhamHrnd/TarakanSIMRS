using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionForm
{
    public string QuestionFormId { get; set; } = null!;

    public string QuestionFormName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsMcuform { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ReportProgramId { get; set; }

    public bool IsAskepForm { get; set; }

    public bool? IsVsignForm { get; set; }

    public bool? IsSingleEntry { get; set; }

    public string? RmNo { get; set; }

    public bool? IsInitialAssessment { get; set; }

    public bool? IsContinuedAssessment { get; set; }

    public bool? IsGeneralForm { get; set; }

    public bool IsNutritionCareForm { get; set; }

    public bool? IsSoapForm { get; set; }

    public string? SrquestionFormType { get; set; }

    public string? SrnsType { get; set; }

    public string? RestrictionUserType { get; set; }

    public bool? IsSharingEdit { get; set; }

    public bool? IsUsingApproval { get; set; }

    public string? SrautoNumber { get; set; }

    public bool? IsModeMapping { get; set; }

    public bool? IsSharingUnApproval { get; set; }

    public bool? IsGenerateReservation { get; set; }
}
