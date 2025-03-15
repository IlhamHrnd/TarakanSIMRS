using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeePaymentGroup
{
    public string PaymentGroupNo { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public string PaymentMethodId { get; set; } = null!;

    public string BankId { get; set; } = null!;

    public decimal PaymentAmount { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? IsDetail { get; set; }

    public decimal? FeeAmountBeforeTax { get; set; }

    public decimal? TaxOnPaymentAmount { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public bool? IsDraft { get; set; }

    public DateTime? ApproveDateTime { get; set; }

    public DateTime? GuaranteeFeeDateFrom { get; set; }

    public DateTime? GuaranteeFeeDateTo { get; set; }
}
