using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PredictiveModel
{
    public int SqlserverId { get; set; }

    public int Metric { get; set; }

    public int Severity { get; set; }

    public int Timeframe { get; set; }

    public byte[] Model { get; set; } = null!;

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
