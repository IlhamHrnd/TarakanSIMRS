using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string? ServerName { get; set; }

    public string Subject { get; set; } = null!;

    public string? Message { get; set; }

    public string? Comments { get; set; }

    public string? Owner { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? CompletedOn { get; set; }

    public byte Status { get; set; }

    public int? Metric { get; set; }

    public byte? Severity { get; set; }

    public double? Value { get; set; }

    public int? EventId { get; set; }

    public string? DatabaseName { get; set; }
}
