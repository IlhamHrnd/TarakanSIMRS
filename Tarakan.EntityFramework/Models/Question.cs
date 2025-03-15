using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Question
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

    public bool? IsActive { get; set; }

    public int? AnswerWidth { get; set; }

    public int? AnswerWidth2 { get; set; }

    public string? QuestionAnswerSelectionId { get; set; }

    public string? QuestionAnswerDefaultSelectionId { get; set; }

    public string? QuestionAnswerSelectionId2 { get; set; }

    public string? QuestionAnswerDefaultSelectionId2 { get; set; }

    public string? Formula { get; set; }

    public bool? IsAlwaysPrint { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsMandatory { get; set; }

    public string? ReferenceQuestionId { get; set; }

    public string? VitalSignId { get; set; }

    public string? BodyId { get; set; }

    public string? RelatedEntityName { get; set; }

    public string? RelatedColumnName { get; set; }

    public string? LookUpId { get; set; }

    public bool? IsUpdateRelatedEntity { get; set; }

    public bool? IsReadOnly { get; set; }

    public string? NursingDisplayAs { get; set; }

    public string? EquivalentQuestionId { get; set; }

    public bool? IsEmptyDefault { get; set; }

    public bool? IsNotOverWriteRelatedEntity { get; set; }
}
