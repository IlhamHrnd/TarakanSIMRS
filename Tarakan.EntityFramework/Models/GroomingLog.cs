using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GroomingLog
{
    public Guid RunId { get; set; }

    public int Sequence { get; set; }

    public DateTime UtcactionEndDateTime { get; set; }

    public string Action { get; set; } = null!;

    public int? AffectedRecords { get; set; }

    public string? InstanceName { get; set; }
}
