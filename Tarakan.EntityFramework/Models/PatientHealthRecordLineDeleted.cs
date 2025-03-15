using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientHealthRecordLineDeleted
{
    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string QuestionFormId { get; set; } = null!;

    public string QuestionGroupId { get; set; } = null!;

    public string QuestionId { get; set; } = null!;

    public string? QuestionAnswerPrefix { get; set; }

    public string? QuestionAnswerSuffix { get; set; }

    public string? QuestionAnswerSelectionLineId { get; set; }

    public string? QuestionAnswerText { get; set; }

    public decimal? QuestionAnswerNum { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? QuestionAnswerText2 { get; set; }

    public byte[]? BodyImage { get; set; }
}
