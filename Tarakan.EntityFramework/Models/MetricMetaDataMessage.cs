using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MetricMetaDataMessage
{
    public int Metric { get; set; }

    public int MessageId { get; set; }

    public long? EventId { get; set; }

    public string HeaderTemplate { get; set; } = null!;

    public string BodyTemplate { get; set; } = null!;

    public string TodoTemplate { get; set; } = null!;

    public string PulseTemplate { get; set; } = null!;

    public string? HeaderTemplateBaseline { get; set; }

    public string? BodyTemplateBaseline { get; set; }

    public string? TodoTemplateBaseline { get; set; }

    public string? PulseTemplateBaseline { get; set; }
}
