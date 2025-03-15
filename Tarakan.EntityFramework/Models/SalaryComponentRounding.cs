using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryComponentRounding
{
    public int SalaryComponentRoundingId { get; set; }

    public string SalaryComponentRoundingName { get; set; } = null!;

    public decimal NominalValue { get; set; }

    public decimal NearestValue { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public int? Formula { get; set; }

    public int? Formula2 { get; set; }
}
