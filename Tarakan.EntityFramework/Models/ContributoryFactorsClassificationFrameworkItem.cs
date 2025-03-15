using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ContributoryFactorsClassificationFrameworkItem
{
    public string FactorId { get; set; } = null!;

    public string FactorItemId { get; set; } = null!;

    public string? FactorItemName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
