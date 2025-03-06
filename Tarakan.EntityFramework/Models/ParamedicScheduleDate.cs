using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicScheduleDate
{
    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public string PeriodYear { get; set; }

    public DateTime ScheduleDate { get; set; }

    public string OperationalTimeId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsClosedTime1 { get; set; }

    public DateTime? ClosedDateTime1 { get; set; }

    public string ClosedTime1ByUserId { get; set; }

    public bool? IsClosedTime2 { get; set; }

    public DateTime? ClosedDateTime2 { get; set; }

    public string ClosedTime2ByUserId { get; set; }

    public bool? IsClosedTime3 { get; set; }

    public DateTime? ClosedDateTime3 { get; set; }

    public string ClosedTime3ByUserId { get; set; }

    public bool? IsClosedTime4 { get; set; }

    public DateTime? ClosedDateTime4 { get; set; }

    public string ClosedTime4ByUserId { get; set; }

    public bool? IsClosedTime5 { get; set; }

    public DateTime? ClosedDateTime5 { get; set; }

    public string ClosedTime5ByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public bool? IsIpr { get; set; }

    public bool? IsOpr { get; set; }

    public bool? IsEmr { get; set; }

    public string PeriodMonth { get; set; }

    public short? AddQuota { get; set; }

    public short? AddQuotaOnline { get; set; }

    public short? AddQuotaBpjs { get; set; }

    public short? AddQuotaBpjsOnline { get; set; }
}
