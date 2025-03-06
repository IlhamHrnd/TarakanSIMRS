using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeIncentivePosition
{
    public int IncentivePositionId { get; set; }

    public int PersonId { get; set; }

    public string SrincentiveServiceUnitGroup { get; set; }

    public string SrincentivePositionGroup { get; set; }

    public string SrincentivePosition { get; set; }

    public decimal IncentivePositionPoints { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
