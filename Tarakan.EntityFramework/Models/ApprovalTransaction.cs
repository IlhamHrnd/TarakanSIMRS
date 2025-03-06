using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApprovalTransaction
{
    public string TransactionNo { get; set; }

    public int ApprovalLevel { get; set; }

    public string UserId { get; set; }

    public string ApprovalRangeId { get; set; }

    public bool IsApprovalLevelFinal { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string ApprovedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string TransactionCode { get; set; }
}
