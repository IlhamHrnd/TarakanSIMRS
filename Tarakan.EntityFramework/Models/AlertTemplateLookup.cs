using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AlertTemplateLookup
{
    public int TemplateId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool Default { get; set; }

    public virtual ICollection<DefaultMetricThreshold> DefaultMetricThresholds { get; set; } = new List<DefaultMetricThreshold>();
}
