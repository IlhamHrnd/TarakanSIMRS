using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DistributionPortion
{
    public string OrderNo { get; set; }

    public string SrmealSet { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsInvalid { get; set; }

    public string SrinvalidReason { get; set; }

    public string CheckedByUserId { get; set; }

    public DateTime? CheckedDateTime { get; set; }
}
