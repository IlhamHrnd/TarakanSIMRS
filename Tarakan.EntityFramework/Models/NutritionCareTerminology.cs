using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareTerminology
{
    public string TerminologyId { get; set; }

    public string TerminologyName { get; set; }

    public string TerminologyDesc { get; set; }

    public string SrnutritionCareTerminologyLevel { get; set; }

    public string SequenceNo { get; set; }

    public string TerminologyParentId { get; set; }

    public int? TerminologyLevel { get; set; }

    public string DomainId { get; set; }

    public bool? IsDetail { get; set; }

    public string RespondTemplate { get; set; }

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public virtual ICollection<NutritionCareAssessmentQuestionDiagnose> NutritionCareAssessmentQuestionDiagnoses { get; set; } = new List<NutritionCareAssessmentQuestionDiagnose>();
}
