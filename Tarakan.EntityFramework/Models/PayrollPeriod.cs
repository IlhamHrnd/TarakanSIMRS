using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PayrollPeriod
{
    public int PayrollPeriodId { get; set; }

    public string PayrollPeriodCode { get; set; }

    public string PayrollPeriodName { get; set; }

    public string SrpaySequent { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime PayDate { get; set; }

    public int Sptyear { get; set; }

    public int Sptmonth { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? WageProcessTypeId { get; set; }

    public bool? IsMoslemThr { get; set; }
}
