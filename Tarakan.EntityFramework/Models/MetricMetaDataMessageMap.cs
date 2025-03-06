using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MetricMetaDataMessageMap
{
    public int Metric { get; set; }

    public int Value { get; set; }

    public int MessageId { get; set; }
}
