using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BaselineMetaDatum
{
    public int ItemId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Category { get; set; }

    public string Unit { get; set; }

    public string Format { get; set; }

    public string NullFormat { get; set; }

    public int? MetricId { get; set; }

    public string StatisticTable { get; set; }

    public string MetricValue { get; set; }

    public int? Decimals { get; set; }

    public int? Llimit { get; set; }

    public long? Ulimit { get; set; }

    public decimal? Scale { get; set; }
}
