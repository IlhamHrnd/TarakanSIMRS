using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareAssessmentTransDt
{
    public long Id { get; set; }

    public long Hdid { get; set; }

    public string QuestionId { get; set; } = null!;

    public string QuestionText { get; set; } = null!;

    public bool IsSubjective { get; set; }

    public bool IsObjective { get; set; }

    public string? AnswerPrefix { get; set; }

    public string? AnswerSuffix { get; set; }

    public string? AnswerText { get; set; }

    public decimal? AnswerNum { get; set; }

    public string? AnswerSelectionLineId { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
