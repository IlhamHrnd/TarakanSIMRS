using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareAssessmentQuestionDiagnose
{
    public string QuestionId { get; set; }

    public string TerminologyId { get; set; }

    public int AgeInMonthStart { get; set; }

    public int AgeInMonthEnd { get; set; }

    public string SranswerType { get; set; }

    public string Operand { get; set; }

    public string AcceptedText { get; set; }

    public decimal? AcceptedNum { get; set; }

    public decimal? AcceptedNum2 { get; set; }

    public bool CheckValue { get; set; }

    public bool? IsUsingRange { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public virtual NutritionCareTerminology Terminology { get; set; }
}
