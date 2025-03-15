using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialQuestionnaireItem
{
    public int QuestionnaireItemId { get; set; }

    public int QuestionnaireId { get; set; }

    public string QuestionCode { get; set; } = null!;

    public string QuestionNo { get; set; } = null!;

    public string QuestionName { get; set; } = null!;

    public string SrcredentialQuestionLevel { get; set; } = null!;

    public string SrcredentialActionType { get; set; } = null!;

    public bool IsDetail { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
