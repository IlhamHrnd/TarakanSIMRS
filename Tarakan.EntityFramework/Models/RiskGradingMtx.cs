using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskGradingMtx
{
    public string SrclinicalImpact { get; set; } = null!;

    public string SrincidentProbabilityFrequency { get; set; } = null!;

    public string SrincidentFollowUp { get; set; } = null!;

    public string RiskGradingId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
