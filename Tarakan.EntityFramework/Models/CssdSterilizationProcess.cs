using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterilizationProcess
{
    public string ProcessNo { get; set; }

    public DateTime ProcessDate { get; set; }

    public string ProcessStartTime { get; set; }

    public string ProcessEndTime { get; set; }

    public string MachineId { get; set; }

    public string SrcssdProcessType { get; set; }

    public string OperatorByUserId { get; set; }

    public string ProcessTo { get; set; }

    public bool? IsDtt { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? ExpiredDate { get; set; }
}
