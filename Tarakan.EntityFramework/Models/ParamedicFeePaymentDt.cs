using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeePaymentDt
{
    public string PaymentNo { get; set; }

    public string VerificationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
