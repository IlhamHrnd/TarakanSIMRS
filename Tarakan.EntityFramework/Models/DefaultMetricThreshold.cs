using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DefaultMetricThreshold
{
    public int UserViewId { get; set; }

    public int Metric { get; set; }

    public bool Enabled { get; set; }

    public string WarningThreshold { get; set; }

    public string CriticalThreshold { get; set; }

    public string Data { get; set; }

    public string InfoThreshold { get; set; }

    public int ThresholdInstanceId { get; set; }

    public bool ThresholdEnabled { get; set; }

    public bool IsBaselineEnabled { get; set; }

    public string BaselineWarningThreshold { get; set; }

    public string BaselineCriticalThreshold { get; set; }

    public string BaselineInfoThreshold { get; set; }

    public virtual AlertTemplateLookup UserView { get; set; }
}
