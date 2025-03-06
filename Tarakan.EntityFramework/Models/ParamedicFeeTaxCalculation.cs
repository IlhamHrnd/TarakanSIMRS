using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeTaxCalculation
{
    public long Id { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public string ParamedicId { get; set; }

    public string SrpphType { get; set; }

    public short Period { get; set; }

    public bool IsNpwp { get; set; }

    public decimal TaxInPercent { get; set; }

    public decimal FeeAmount { get; set; }

    public decimal FeeAmountAccumulated { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal TaxAmountAccumulated { get; set; }

    public string VerificationNo { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime InsertDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public long? JournalId { get; set; }

    public bool? IsTaxFromPayment { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public string PaymentGroupNo { get; set; }
}
