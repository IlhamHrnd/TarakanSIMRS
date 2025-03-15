using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanNonJptTx
{
    public long TxId { get; set; }

    public int PersonId { get; set; }

    public int PerformancePlanId { get; set; }

    public string YearPeriod { get; set; } = null!;

    public bool? IsVerification { get; set; }

    public DateTime? VerificationDateTime { get; set; }

    public string? VerificationByUserId { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? ClosedDateTime { get; set; }

    public string? ClosedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
