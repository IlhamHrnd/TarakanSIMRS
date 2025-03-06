using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialQuestionnaireItem
{
    public int QuestionnaireItemId { get; set; }

    public int QuestionnaireId { get; set; }

    public string QuestionCode { get; set; }

    public string QuestionNo { get; set; }

    public string QuestionName { get; set; }

    public string SrcredentialQuestionLevel { get; set; }

    public string SrcredentialActionType { get; set; }

    public bool IsDetail { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
