using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CostCalculationIntermBillTemp
{
    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string IntermBillNo { get; set; } = null!;

    public string PaymentNo { get; set; } = null!;
}
