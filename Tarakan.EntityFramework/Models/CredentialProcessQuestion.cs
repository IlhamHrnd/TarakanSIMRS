using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialProcessQuestion
{
    public string TransactionNo { get; set; }

    public string QuestionFormId { get; set; }

    public string QuestionGroupId { get; set; }

    public string QuestionId { get; set; }

    public string QuestionAnswerPrefix { get; set; }

    public string QuestionAnswerSuffix { get; set; }

    public string QuestionAnswerSelectionLineId { get; set; }

    public string QuestionAnswerText { get; set; }

    public string QuestionAnswerText2 { get; set; }

    public decimal? QuestionAnswerNum { get; set; }

    public byte[] BodyImage { get; set; }
}
