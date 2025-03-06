using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RiskFactor
{
    public string SrriskFactorsType { get; set; }

    public string RiskFactorsId { get; set; }

    public string RiskFactorsName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
