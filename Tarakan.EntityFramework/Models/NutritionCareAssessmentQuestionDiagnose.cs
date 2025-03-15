using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareAssessmentQuestionDiagnose
{
    public string QuestionId { get; set; } = null!;

    public string TerminologyId { get; set; } = null!;

    public int AgeInMonthStart { get; set; }

    public int AgeInMonthEnd { get; set; }

    public string? SranswerType { get; set; }

    public string? Operand { get; set; }

    public string? AcceptedText { get; set; }

    public decimal? AcceptedNum { get; set; }

    public decimal? AcceptedNum2 { get; set; }

    public bool CheckValue { get; set; }

    public bool? IsUsingRange { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public virtual NutritionCareTerminology Terminology { get; set; } = null!;
}
