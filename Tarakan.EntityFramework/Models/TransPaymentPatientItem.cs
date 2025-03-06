using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentPatientItem
{
    public string PaymentNo { get; set; }

    public string SequenceNo { get; set; }

    public string SrpaymentType { get; set; }

    public string SrpaymentMethod { get; set; }

    public string SrcardProvider { get; set; }

    public string SrcardType { get; set; }

    public string EdcmachineId { get; set; }

    public string CardHolderName { get; set; }

    public decimal? CardFeeAmount { get; set; }

    public string BankId { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string CardNo { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceSequenceNo { get; set; }
}
