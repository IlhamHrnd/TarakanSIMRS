using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicLeave
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string ParamedicId { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string SrphysicianLeaveReason { get; set; } = null!;

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? SubsParamedicIp { get; set; }

    public string? SubsParamedicOp { get; set; }

    public string? SubsParamedicEmr { get; set; }
}
