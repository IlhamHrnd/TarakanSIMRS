using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppAutoNumberLast
{
    public string SrautoNumber { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string DepartmentInitial { get; set; }

    public int YearNo { get; set; }

    public int MonthNo { get; set; }

    public int DayNo { get; set; }

    public int? LastNumber { get; set; }

    public string LastCompleteNumber { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
