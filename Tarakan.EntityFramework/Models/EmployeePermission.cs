using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeePermission
{
    public long PermissionId { get; set; }

    public DateTime PermissionDate { get; set; }

    public int SupervisorId { get; set; }

    public int PersonId { get; set; }

    public string SrpermissionType { get; set; }

    public DateTime PermissionDateFrom { get; set; }

    public DateTime PermissionDateTo { get; set; }

    public string Notes { get; set; }

    public bool? IsPayCut { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string VerifiedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string PermissionTimeFrom { get; set; }

    public string PermissionTimeTo { get; set; }

    public int? PayCutDays { get; set; }
}
