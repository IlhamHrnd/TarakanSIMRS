using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class StructuralBenefit
{
    public int OrganizationUnitId { get; set; }

    public int PositionId { get; set; }

    public DateTime ValidFrom { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
