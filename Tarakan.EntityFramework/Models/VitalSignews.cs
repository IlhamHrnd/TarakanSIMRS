using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VitalSignews
{
    public string VitalSignId { get; set; } = null!;

    public int StartAgeInDay { get; set; }

    public int IndexNo { get; set; }

    public int ChartMinValue { get; set; }

    public int ChartMaxValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsExcludeFromScoreEws { get; set; }
}
