using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalScoringAccumulation
{
    public int ScoringAccumulationId { get; set; }

    public int ParticipantItemId { get; set; }

    public int QuestionerItemId { get; set; }

    public decimal? SupervisorScore { get; set; }

    public decimal? PartnerScore { get; set; }

    public decimal? SubordinateScore { get; set; }

    public decimal? SelfScore { get; set; }

    public decimal? SupervisorScoreIntervention { get; set; }

    public decimal? PartnerScoreIntervention { get; set; }

    public decimal? SubordinateScoreIntervention { get; set; }

    public decimal? SelfScoreIntervention { get; set; }

    public decimal? AverageScore { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
