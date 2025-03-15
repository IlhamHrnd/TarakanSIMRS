using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterilizationProcess
{
    public string ProcessNo { get; set; } = null!;

    public DateTime ProcessDate { get; set; }

    public string ProcessStartTime { get; set; } = null!;

    public string ProcessEndTime { get; set; } = null!;

    public string MachineId { get; set; } = null!;

    public string SrcssdProcessType { get; set; } = null!;

    public string OperatorByUserId { get; set; } = null!;

    public string ProcessTo { get; set; } = null!;

    public bool? IsDtt { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? ExpiredDate { get; set; }
}
