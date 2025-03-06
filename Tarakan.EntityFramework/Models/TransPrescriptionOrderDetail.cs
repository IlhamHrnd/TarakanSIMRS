using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionOrderDetail
{
    public string OrderNo { get; set; }

    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string CreateBy { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateBy { get; set; }
}
