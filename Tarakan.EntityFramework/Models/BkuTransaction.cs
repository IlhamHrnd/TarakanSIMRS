using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BkuTransaction
{
    public int BkuId { get; set; }

    public int? RekeningId { get; set; }

    public int? UnitId { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public string? Uraian { get; set; }

    public string? PaymentReferenceNo { get; set; }

    public string? InvoiceReferenceNo { get; set; }

    public string? TransactionReferenceNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
