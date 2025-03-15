using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskFactor
{
    public string SrriskFactorsType { get; set; } = null!;

    public string RiskFactorsId { get; set; } = null!;

    public string RiskFactorsName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
