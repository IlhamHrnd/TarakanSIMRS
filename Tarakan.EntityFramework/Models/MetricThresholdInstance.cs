using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MetricThresholdInstance
{
    public int InstanceId { get; set; }

    public int InstanceType { get; set; }

    public string? ThresholdInstanceName { get; set; }

    public DateTime? CreationDateTime { get; set; }
}
