using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskManagementItem
{
    public string RiskManagementNo { get; set; }

    public string SequenceNo { get; set; }

    public string SrriskManagementCategory { get; set; }

    public string RiskManagementDescription { get; set; }

    public string SrriskManagementImpact { get; set; }

    public short ImpactScore { get; set; }

    public string SrriskManagementProbability { get; set; }

    public short ProbabilityScore { get; set; }

    public short RiskScore { get; set; }

    public string SrriskManagementBands { get; set; }

    public string SrriskManagementControlling { get; set; }

    public short ControllingScore { get; set; }

    public short TotalScore { get; set; }

    public short RiskRating { get; set; }

    public string Reason { get; set; }

    public string Action { get; set; }

    public string Pic { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
