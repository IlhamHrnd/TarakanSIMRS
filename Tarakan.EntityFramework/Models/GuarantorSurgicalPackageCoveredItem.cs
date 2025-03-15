using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorSurgicalPackageCoveredItem
{
    public string GuarantorId { get; set; } = null!;

    public string PackageId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal CoveredAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
