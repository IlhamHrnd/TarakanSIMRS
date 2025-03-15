using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptionReview
{
    public string PrescriptionNo { get; set; } = null!;

    public string SrprescReview { get; set; } = null!;

    public bool? IsRight { get; set; }

    public string? Information { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
