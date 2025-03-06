using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrintSlipLog
{
    public long LogId { get; set; }

    public string ProgramId { get; set; }

    public string ParameterName { get; set; }

    public string ParameterValue { get; set; }

    public short PrintCount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
