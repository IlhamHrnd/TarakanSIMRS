using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskGradingMtx
{
    public string SrclinicalImpact { get; set; }

    public string SrincidentProbabilityFrequency { get; set; }

    public string SrincidentFollowUp { get; set; }

    public string RiskGradingId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
