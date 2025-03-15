using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppSrassessmentType
{
    public string SrassessmentType { get; set; } = null!;

    public string? ContinuedSrassessmentType { get; set; }

    public bool? IsInitialAssessment { get; set; }

    public bool? IsSingleEntry { get; set; }

    public string? SrregistrationType { get; set; }

    public string? ReportProgramId { get; set; }

    public string? NursingQuestionFormId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
