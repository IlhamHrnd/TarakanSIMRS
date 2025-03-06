using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PphProgressiveTax
{
    public int CounterId { get; set; }

    public decimal? MinAmount { get; set; }

    public decimal? MaxAmount { get; set; }

    public decimal? Percentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
