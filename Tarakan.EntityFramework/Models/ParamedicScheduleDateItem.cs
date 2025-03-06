using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicScheduleDateItem
{
    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public DateTime ScheduleDate { get; set; }

    public string OperationalTimeId { get; set; }

    public bool IsIpr { get; set; }

    public bool IsOpr { get; set; }

    public bool IsEmr { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
