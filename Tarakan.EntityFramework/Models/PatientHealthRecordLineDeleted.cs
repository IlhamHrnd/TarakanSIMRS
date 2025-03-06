using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientHealthRecordLineDeleted
{
    public string TransactionNo { get; set; }

    public string RegistrationNo { get; set; }

    public string QuestionFormId { get; set; }

    public string QuestionGroupId { get; set; }

    public string QuestionId { get; set; }

    public string QuestionAnswerPrefix { get; set; }

    public string QuestionAnswerSuffix { get; set; }

    public string QuestionAnswerSelectionLineId { get; set; }

    public string QuestionAnswerText { get; set; }

    public decimal? QuestionAnswerNum { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string QuestionAnswerText2 { get; set; }

    public byte[] BodyImage { get; set; }
}
