using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomCounterDefinition
{
    public int Metric { get; set; }

    public DateTime UtclastChangeDateTime { get; set; }

    public int MetricType { get; set; }

    public int CalculationType { get; set; }

    public bool Enabled { get; set; }

    public double Scale { get; set; }

    public string Object { get; set; }

    public string Counter { get; set; }

    public string Instance { get; set; }

    public string Batch { get; set; }

    public string ServerType { get; set; }

    public long? AzureProfileId { get; set; }

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
