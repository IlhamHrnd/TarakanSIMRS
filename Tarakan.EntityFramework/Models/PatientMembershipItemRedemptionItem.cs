using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientMembershipItemRedemptionItem
{
    public string TransactionNo { get; set; }

    public string ItemReedemId { get; set; }

    public decimal Qty { get; set; }

    public decimal PointsUsed { get; set; }

    public decimal TotalPointsUsed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
