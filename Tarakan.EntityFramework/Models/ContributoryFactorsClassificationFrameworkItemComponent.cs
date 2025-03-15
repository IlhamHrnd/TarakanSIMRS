using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ContributoryFactorsClassificationFrameworkItemComponent
{
    public string FactorId { get; set; } = null!;

    public string FactorItemId { get; set; } = null!;

    public string ComponentId { get; set; } = null!;

    public string? ComponentName { get; set; }

    public bool? IsAllowEdit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
