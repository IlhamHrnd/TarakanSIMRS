using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PayrollPeriod
{
    public int PayrollPeriodId { get; set; }

    public string PayrollPeriodCode { get; set; } = null!;

    public string PayrollPeriodName { get; set; } = null!;

    public string SrpaySequent { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime PayDate { get; set; }

    public int Sptyear { get; set; }

    public int Sptmonth { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public int? WageProcessTypeId { get; set; }

    public bool? IsMoslemThr { get; set; }
}
