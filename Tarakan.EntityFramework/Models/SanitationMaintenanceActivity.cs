using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SanitationMaintenanceActivity
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string SrworkTradeItem { get; set; }

    public string ServiceUnitId { get; set; }

    public DateTime TargetDate { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
