using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrintSlipLog
{
    public long LogId { get; set; }

    public string ProgramId { get; set; } = null!;

    public string ParameterName { get; set; } = null!;

    public string ParameterValue { get; set; } = null!;

    public short PrintCount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
