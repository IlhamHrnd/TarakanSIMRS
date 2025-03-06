using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskGrading
{
    public string RiskGradingId { get; set; }

    public string RiskGradingName { get; set; }

    public string RiskGradingColor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
