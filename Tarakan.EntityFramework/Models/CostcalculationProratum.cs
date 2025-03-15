using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CostcalculationProratum
{
    public string PaymentNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
