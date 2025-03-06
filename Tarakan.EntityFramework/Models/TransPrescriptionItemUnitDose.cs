using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemUnitDose
{
    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceSequenceNo { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string ItemId { get; set; }

    public decimal ResultQty { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal EmbalaceAmount { get; set; }

    public decimal SweetenerAmount { get; set; }

    public decimal LineAmount { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
