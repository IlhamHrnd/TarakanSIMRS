using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareTerminology
{
    public string TerminologyId { get; set; } = null!;

    public string? TerminologyName { get; set; }

    public string? TerminologyDesc { get; set; }

    public string SrnutritionCareTerminologyLevel { get; set; } = null!;

    public string? SequenceNo { get; set; }

    public string? TerminologyParentId { get; set; }

    public int? TerminologyLevel { get; set; }

    public string? DomainId { get; set; }

    public bool? IsDetail { get; set; }

    public string? RespondTemplate { get; set; }

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public virtual ICollection<NutritionCareAssessmentQuestionDiagnose> NutritionCareAssessmentQuestionDiagnoses { get; set; } = new List<NutritionCareAssessmentQuestionDiagnose>();
}
