using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Alert
{
    public long AlertId { get; set; }

    public DateTime UtcoccurrenceDateTime { get; set; }

    public string? ServerName { get; set; }

    public string? DatabaseName { get; set; }

    public string? TableName { get; set; }

    public bool? Active { get; set; }

    public int? Metric { get; set; }

    public byte? Severity { get; set; }

    public byte? StateEvent { get; set; }

    public double? Value { get; set; }

    public string? Heading { get; set; }

    public string? Message { get; set; }

    public string? QualifierHash { get; set; }

    public Guid? LinkedData { get; set; }

    public virtual MonitoredSqlserver? ServerNameNavigation { get; set; }
}
