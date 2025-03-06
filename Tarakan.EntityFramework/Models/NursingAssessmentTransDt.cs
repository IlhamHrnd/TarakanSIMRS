using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingAssessmentTransDt
{
    public long Id { get; set; }

    public long Hdid { get; set; }

    public string QuestionId { get; set; }

    public string QuestionText { get; set; }

    public bool IsSubjective { get; set; }

    public bool IsObjective { get; set; }

    public string AnswerPrefix { get; set; }

    public string AnswerSuffix { get; set; }

    public string AnswerText { get; set; }

    public decimal? AnswerNum { get; set; }

    public string AnswerSelectionLineId { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
