using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PredictiveForecast
{
    public int SqlserverId { get; set; }

    public int Metric { get; set; }

    public int Severity { get; set; }

    public int Timeframe { get; set; }

    public int Forecast { get; set; }

    public decimal Accuracy { get; set; }

    public DateTime Expiration { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }
}
