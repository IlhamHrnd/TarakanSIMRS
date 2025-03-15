using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionOrderDetail
{
    public string OrderNo { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateBy { get; set; }
}
