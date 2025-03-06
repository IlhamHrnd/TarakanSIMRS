using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemTempCoverage
{
    public string RegistrationNo { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceSequenceNo { get; set; }

    public string ItemId { get; set; }

    public string ChargeClassId { get; set; }

    public decimal ChargeQuantity { get; set; }

    public decimal Price { get; set; }

    public string ParamedicCollectionName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
