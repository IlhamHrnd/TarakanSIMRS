using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionProgress
{
    public string PrescriptionNo { get; set; }

    public string SrprescriptionProgress { get; set; }

    public int ProgressNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
