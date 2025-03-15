using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentAdditionalCharge
{
    public string SrcafeAdditionalCharges { get; set; } = null!;

    public string PaymentNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public decimal ChargeAmount { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool IsVoid { get; set; }
}
