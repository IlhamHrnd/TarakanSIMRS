using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpItemMinmax
{
    public string ItemId { get; set; }

    public string LocationId { get; set; }

    public DateOnly GenerateDate { get; set; }

    public decimal Minimum { get; set; }

    public decimal Maximum { get; set; }

    public int? GenerateType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string GeneratePeriod { get; set; }
}
