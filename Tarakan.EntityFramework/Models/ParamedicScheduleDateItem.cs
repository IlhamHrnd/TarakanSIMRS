using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicScheduleDateItem
{
    public string ServiceUnitId { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public string OperationalTimeId { get; set; } = null!;

    public bool IsIpr { get; set; }

    public bool IsOpr { get; set; }

    public bool IsEmr { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
