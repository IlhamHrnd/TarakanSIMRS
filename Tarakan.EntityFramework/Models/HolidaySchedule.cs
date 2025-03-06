using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HolidaySchedule
{
    public string PeriodYear { get; set; }

    public DateTime HolidayDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
