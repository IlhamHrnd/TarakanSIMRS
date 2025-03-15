using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalScoresheet
{
    public int ScoresheetId { get; set; }

    public int ParticipantItemId { get; set; }

    public int EvaluatorId { get; set; }

    public int? ReferenceId { get; set; }

    public string? PeriodYear { get; set; }

    public DateTime? ScoringDate { get; set; }

    public string? SrevaluatorType { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
