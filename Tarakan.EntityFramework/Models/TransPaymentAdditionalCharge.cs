using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentAdditionalCharge
{
    public string SrcafeAdditionalCharges { get; set; }

    public string PaymentNo { get; set; }

    public string RegistrationNo { get; set; }

    public decimal ChargeAmount { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool IsVoid { get; set; }
}
