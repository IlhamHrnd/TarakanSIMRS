using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeLeave
{
    public long EmployeeLeaveId { get; set; }

    public int PersonId { get; set; }

    public string SremployeeLeaveType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int LeaveEntitlementsQty { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsPayCut { get; set; }
}
