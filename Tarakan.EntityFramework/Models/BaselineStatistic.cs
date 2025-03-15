using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BaselineStatistic
{
    public DateTime Utccalculation { get; set; }

    public int SqlserverId { get; set; }

    public int TemplateId { get; set; }

    public int MetricId { get; set; }

    public decimal Mean { get; set; }

    public decimal StdDeviation { get; set; }

    public decimal Min { get; set; }

    public decimal Max { get; set; }

    public long Count { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
