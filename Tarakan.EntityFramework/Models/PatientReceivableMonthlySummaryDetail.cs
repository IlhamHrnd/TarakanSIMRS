using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientReceivableMonthlySummaryDetail
{
    public long DetailId { get; set; }

    public int? Id { get; set; }

    public string? SrbillingGroup { get; set; }

    public int? ChartOfAccountId { get; set; }

    public decimal? Amount { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool? IsRevenue { get; set; }
}
