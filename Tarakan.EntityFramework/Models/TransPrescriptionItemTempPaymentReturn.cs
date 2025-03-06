using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemTempPaymentReturn
{
    public string Prescription { get; set; }

    public string SequenceNo { get; set; }

    public string IntermBillNo { get; set; }

    public string PaymentNo { get; set; }

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }

    public decimal? LineAmount { get; set; }
}
