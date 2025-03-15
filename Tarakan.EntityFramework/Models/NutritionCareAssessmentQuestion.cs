using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareAssessmentQuestion
{
    public string QuestionId { get; set; } = null!;

    public string? ParentQuestionId { get; set; }

    public int? IndexNo { get; set; }

    public int? QuestionLevel { get; set; }

    public string QuestionText { get; set; } = null!;

    public string? QuestionShortText { get; set; }

    public string SranswerType { get; set; } = null!;

    public int? AnswerDecimalDigit { get; set; }

    public string? AnswerPrefix { get; set; }

    public string? AnswerSuffix { get; set; }

    public int? AnswerWidth { get; set; }

    public int? AnswerWidth2 { get; set; }

    public string? QuestionAnswerSelectionId { get; set; }

    public string? QuestionAnswerDefaultSelectionId { get; set; }

    public string? QuestionAnswerSelectionId2 { get; set; }

    public string? QuestionAnswerDefaultSelectionId2 { get; set; }

    public string? Formula { get; set; }

    public bool? IsAlwaysPrint { get; set; }

    public bool? IsMandatory { get; set; }

    public bool IsSubjective { get; set; }

    public bool IsObjective { get; set; }

    public string? RelatedQuestionId { get; set; }

    public bool? IsActive { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
