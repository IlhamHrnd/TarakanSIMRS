using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeIncentivePosition
{
    public int IncentivePositionId { get; set; }

    public int PersonId { get; set; }

    public string SrincentiveServiceUnitGroup { get; set; } = null!;

    public string SrincentivePositionGroup { get; set; } = null!;

    public string SrincentivePosition { get; set; } = null!;

    public decimal IncentivePositionPoints { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
