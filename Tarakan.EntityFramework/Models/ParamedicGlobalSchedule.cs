using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicGlobalSchedule
{
    public string ParamedicId { get; set; }

    public string ServiceUnitId { get; set; }

    public int DayOfWeek { get; set; }

    public string OperationalTimeId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
