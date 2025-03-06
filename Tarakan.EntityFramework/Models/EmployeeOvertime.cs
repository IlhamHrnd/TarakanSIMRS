using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeOvertime
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public int PayrollPeriodId { get; set; }

    public int SupervisorId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsValidated { get; set; }

    public DateTime? ValidatedDateTime { get; set; }

    public string ValidatedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string VerifiedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
