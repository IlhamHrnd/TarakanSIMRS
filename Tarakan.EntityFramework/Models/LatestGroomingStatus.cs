using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LatestGroomingStatus
{
    public int? SqlserverId { get; set; }

    public Guid GroomingRunId { get; set; }

    public DateTime? GroomingDateTimeUtc { get; set; }

    public short? Status { get; set; }

    public string? LastStatusMessage { get; set; }

    public bool? IsPrimary { get; set; }

    public virtual MonitoredSqlserver? Sqlserver { get; set; }
}
