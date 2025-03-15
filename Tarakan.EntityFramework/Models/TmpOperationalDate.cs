using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpOperationalDate
{
    public double? OperationalTimeId { get; set; }

    public string? OperationalTimeName { get; set; }

    public DateTime? StartTime1 { get; set; }

    public DateTime? EndTime1 { get; set; }

    public string? StartTime2 { get; set; }

    public string? EndTime2 { get; set; }

    public string? StartTime3 { get; set; }

    public string? EndTime3 { get; set; }

    public string? StartTime4 { get; set; }

    public string? EndTime4 { get; set; }

    public string? StartTime5 { get; set; }

    public string? EndTime5 { get; set; }

    public string? OperationalTimeBackcolor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
