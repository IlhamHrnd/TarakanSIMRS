using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApprovalRange
{
    public string ApprovalRangeId { get; set; }

    public string SritemType { get; set; }

    public decimal AmountFrom { get; set; }

    public int ApprovalLevelFinal { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ItemGroupId { get; set; }

    public string TransactionCode { get; set; }
}
