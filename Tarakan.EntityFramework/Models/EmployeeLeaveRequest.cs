using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeLeaveRequest
{
    public long LeaveRequestId { get; set; }

    public DateTime RequestDate { get; set; }

    public int PersonId { get; set; }

    public long EmployeeLeaveId { get; set; }

    public DateTime RequestLeaveDateFrom { get; set; }

    public DateTime RequestLeaveDateTo { get; set; }

    public int RequestDays { get; set; }

    public DateTime RequestWorkingDate { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public bool? IsRequestApproved { get; set; }

    public DateTime? ApprovedLeaveDateFrom { get; set; }

    public DateTime? ApprovedLeaveDateTo { get; set; }

    public int? ApprovedDays { get; set; }

    public DateTime? ApprovedWorkingDate { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsValidated { get; set; }

    public DateTime? ValidatedDateTime { get; set; }

    public string? ValidatedByUserId { get; set; }

    public int? ReplacementPersonId { get; set; }

    public string? RejectedReason { get; set; }

    public bool? IsValidated2 { get; set; }

    public DateTime? Validated2DateTime { get; set; }

    public string? Validated2ByUserId { get; set; }

    public int? PayCutDays { get; set; }

    public string? SrworkingDay { get; set; }

    public int? PayrollPeriodId { get; set; }

    public bool? IsPayCut { get; set; }
}
