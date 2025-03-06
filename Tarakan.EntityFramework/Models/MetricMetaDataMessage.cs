using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MetricMetaDataMessage
{
    public int Metric { get; set; }

    public int MessageId { get; set; }

    public long? EventId { get; set; }

    public string HeaderTemplate { get; set; }

    public string BodyTemplate { get; set; }

    public string TodoTemplate { get; set; }

    public string PulseTemplate { get; set; }

    public string HeaderTemplateBaseline { get; set; }

    public string BodyTemplateBaseline { get; set; }

    public string TodoTemplateBaseline { get; set; }

    public string PulseTemplateBaseline { get; set; }
}
