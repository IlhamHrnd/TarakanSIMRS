using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeTransPayment
{
    public int Id { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public string PaymentRefNo { get; set; }

    public DateTime PaymentRefDate { get; set; }

    public bool IsVoid { get; set; }

    public decimal AmountPercentage { get; set; }

    public decimal Amount { get; set; }

    public decimal DiscountAmount { get; set; }

    public string PaymentGroupNo { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string GuarantorId { get; set; }

    public string VerificationNo { get; set; }

    public bool? IsProporsional { get; set; }
}
