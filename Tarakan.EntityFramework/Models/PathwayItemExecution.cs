using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathwayItemExecution
{
    public string PathwayId { get; set; } = null!;

    public int PathwayItemSeqNo { get; set; }

    public int DayNo { get; set; }

    public string SrpathwayExecutionType { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
