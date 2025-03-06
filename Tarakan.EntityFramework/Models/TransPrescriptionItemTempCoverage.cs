using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemTempCoverage
{
    public string RegistrationNo { get; set; }

    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public string ChargeClassId { get; set; }

    public decimal ResultQty { get; set; }

    public decimal Price { get; set; }

    public decimal LineAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
