using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodTransformationItem
{
    public string TransactionNo { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public string SrbloodGroupFrom { get; set; } = null!;

    public string SrbloodGroupTo { get; set; } = null!;

    public DateTime? ExpiredDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? VolumeBag { get; set; }
}
