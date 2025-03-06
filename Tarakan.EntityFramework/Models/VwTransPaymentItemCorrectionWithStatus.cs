using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransPaymentItemCorrectionWithStatus
{
    public string PaymentCorrectionNo { get; set; }

    public string PaymentNo { get; set; }

    public string SequenceNo { get; set; }

    public string SrpaymentType { get; set; }

    public string SrpaymentMethod { get; set; }

    public string SrcardProvider { get; set; }

    public string SrcardType { get; set; }

    public string EdcmachineId { get; set; }

    public decimal? CardFeeAmount { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }
}
