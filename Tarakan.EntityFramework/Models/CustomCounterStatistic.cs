using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomCounterStatistic
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public int MetricId { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public decimal? RawValue { get; set; }

    public decimal? DeltaValue { get; set; }

    public string ErrorMessage { get; set; }

    public double? RunTimeInMilliseconds { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }
}
