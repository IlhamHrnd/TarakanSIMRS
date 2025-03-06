using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemCompTempPaymentReturn
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public string IntermBillNo { get; set; }

    public string PaymentNo { get; set; }

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }
}
