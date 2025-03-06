using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CostCalculationBuffer
{
    public string RegistrationNo { get; set; }

    public string GuarantorId { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public decimal PatientAmount { get; set; }

    public decimal GuarantorAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal ParamedicAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string PaymentNo { get; set; }
}
