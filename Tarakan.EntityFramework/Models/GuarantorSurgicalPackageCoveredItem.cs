using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorSurgicalPackageCoveredItem
{
    public string GuarantorId { get; set; }

    public string PackageId { get; set; }

    public string ItemId { get; set; }

    public decimal CoveredAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
