using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeePaymentHd
{
    public string PaymentNo { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string? PaymentMethodId { get; set; }

    public string? BankId { get; set; }

    public string? BankAccountNo { get; set; }

    public decimal? PaymentAmount { get; set; }

    public bool? IsVoid { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? PaymentGroupNo { get; set; }
}
