using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalScoringRecapitulation
{
    public int ScoringRecapitulationId { get; set; }

    public int ParticipantItemId { get; set; }

    public int QuestionerId { get; set; }

    public string? Capacity { get; set; }

    public string? NeedsToBeDeveloped { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
