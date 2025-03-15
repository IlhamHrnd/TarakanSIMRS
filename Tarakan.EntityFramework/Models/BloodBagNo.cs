using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodBagNo
{
    public string BagNo { get; set; } = null!;

    public string SrbloodType { get; set; } = null!;

    public string BloodRhesus { get; set; } = null!;

    public string SrbloodGroup { get; set; } = null!;

    public DateTime? ExpiredDateTime { get; set; }

    public bool? IsCrossMatching { get; set; }

    public bool? IsExtermination { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? VolumeBag { get; set; }
}
