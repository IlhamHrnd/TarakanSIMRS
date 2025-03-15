using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalParticipantEvaluator
{
    public int ParticipantEvaluatorId { get; set; }

    public int ParticipantItemId { get; set; }

    public int EvaluatorId { get; set; }

    public string SrevaluatorType { get; set; } = null!;

    public int? PositionId { get; set; }

    public DateTime? PositionValidFromDate { get; set; }

    public int? OrganizationUnitId { get; set; }

    public int? SubOrganizationUnitId { get; set; }

    public string? ServiceUnitId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public int? SubDivisonId { get; set; }
}
