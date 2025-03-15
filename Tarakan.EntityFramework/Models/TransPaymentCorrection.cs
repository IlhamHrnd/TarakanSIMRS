using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentCorrection
{
    public string PaymentCorrectionNo { get; set; } = null!;

    public DateTime? PaymentCorrectionDate { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? DateApproved { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool IsVoid { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? DateVoid { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
