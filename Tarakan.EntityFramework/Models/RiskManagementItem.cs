using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskManagementItem
{
    public string RiskManagementNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SrriskManagementCategory { get; set; } = null!;

    public string RiskManagementDescription { get; set; } = null!;

    public string SrriskManagementImpact { get; set; } = null!;

    public short ImpactScore { get; set; }

    public string SrriskManagementProbability { get; set; } = null!;

    public short ProbabilityScore { get; set; }

    public short RiskScore { get; set; }

    public string SrriskManagementBands { get; set; } = null!;

    public string SrriskManagementControlling { get; set; } = null!;

    public short ControllingScore { get; set; }

    public short TotalScore { get; set; }

    public short RiskRating { get; set; }

    public string Reason { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string Pic { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
