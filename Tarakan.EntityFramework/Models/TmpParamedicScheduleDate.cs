using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpParamedicScheduleDate
{
    public string? ServiceUnitId { get; set; }

    public string? ParamedicId { get; set; }

    public double? PeriodYear { get; set; }

    public DateTime? ScheduleDate { get; set; }

    public double? OperationalTimeId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public double? IsClosedTime1 { get; set; }

    public string? ClosedDateTime1 { get; set; }

    public string? ClosedTime1ByUserId { get; set; }

    public double? IsClosedTime2 { get; set; }

    public string? ClosedDateTime2 { get; set; }

    public string? ClosedTime2ByUserId { get; set; }

    public double? IsClosedTime3 { get; set; }

    public string? ClosedDateTime3 { get; set; }

    public string? ClosedTime3ByUserId { get; set; }

    public double? IsClosedTime4 { get; set; }

    public string? ClosedDateTime4 { get; set; }

    public string? ClosedTime4ByUserId { get; set; }

    public double? IsClosedTime5 { get; set; }

    public string? ClosedDateTime5 { get; set; }

    public string? ClosedTime5ByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public double? IsIpr { get; set; }

    public double? IsOpr { get; set; }

    public double? IsEmr { get; set; }
}
