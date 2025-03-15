using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodReceivedItem
{
    public string TransactionNo { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public string SrbloodType { get; set; } = null!;

    public string BloodRhesus { get; set; } = null!;

    public string SrbloodGroup { get; set; } = null!;

    public DateTime? ExpiredDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? VolumeBag { get; set; }
}
