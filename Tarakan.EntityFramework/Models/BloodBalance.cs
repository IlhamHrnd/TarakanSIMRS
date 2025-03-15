using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodBalance
{
    public string SrbloodSource { get; set; } = null!;

    public string SrbloodSourceFrom { get; set; } = null!;

    public string BagNo { get; set; } = null!;

    public decimal Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
