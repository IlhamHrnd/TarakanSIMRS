using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalParticipantQuestioner
{
    public int ParticipantQuestionerId { get; set; }

    public int ParticipantItemId { get; set; }

    public int QuestionerId { get; set; }

    public int? EvaluatorId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
