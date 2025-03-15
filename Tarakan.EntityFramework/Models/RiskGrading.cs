using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskGrading
{
    public string RiskGradingId { get; set; } = null!;

    public string RiskGradingName { get; set; } = null!;

    public string RiskGradingColor { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
