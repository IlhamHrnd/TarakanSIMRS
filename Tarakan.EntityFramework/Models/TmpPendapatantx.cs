using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpPendapatantx
{
    public DateTime? TransactionDate { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public string ParamedicName { get; set; }

    public string ChargeClassId { get; set; }

    public string PaymentNo { get; set; }

    public string UserPayment { get; set; }

    public string UserInput { get; set; }

    public string ToServiceUnitId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public string RegistrationNo { get; set; }

    public decimal? PatientAmount { get; set; }

    public decimal? GuarantorAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? DiscountAmount2 { get; set; }

    public string UserId { get; set; }

    public DateTime? Stime { get; set; }

    public string TransSeqNo { get; set; }
}
