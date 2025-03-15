using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionProgress
{
    public string PrescriptionNo { get; set; } = null!;

    public string SrprescriptionProgress { get; set; } = null!;

    public int ProgressNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
