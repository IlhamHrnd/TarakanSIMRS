using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodBalance
{
    public string SrbloodSource { get; set; }

    public string SrbloodSourceFrom { get; set; }

    public string BagNo { get; set; }

    public decimal Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
