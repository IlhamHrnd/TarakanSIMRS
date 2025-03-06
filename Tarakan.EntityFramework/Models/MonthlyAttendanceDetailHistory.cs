using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MonthlyAttendanceDetailHistory
{
    public long MonthlyAttendanceDetailId { get; set; }

    public int? PersonId { get; set; }

    public int WorkingHourId { get; set; }

    public DateTime? CheckInDateTime { get; set; }

    public DateTime? CheckOutDateTime { get; set; }
}
