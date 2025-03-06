using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentItemIntermBill
{
    public string PaymentNo { get; set; }

    public string IntermBillNo { get; set; }

    public bool IsPaymentProceed { get; set; }

    public bool IsPaymentReturned { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
