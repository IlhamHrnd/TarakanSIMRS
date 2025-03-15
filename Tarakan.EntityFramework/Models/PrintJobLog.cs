using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrintJobLog
{
    public long PrintNo { get; set; }

    public DateTime PrintDateTime { get; set; }

    public string ProgramId { get; set; } = null!;

    public string PrinterId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? ZplCommand { get; set; }

    public bool? IsFailed { get; set; }

    public string? FailedMessage { get; set; }

    public string? ApplicationId { get; set; }

    public string? UserHostName { get; set; }
}
