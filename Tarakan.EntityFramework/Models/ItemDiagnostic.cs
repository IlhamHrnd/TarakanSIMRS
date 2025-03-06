using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemDiagnostic
{
    public string ItemId { get; set; }

    public string ReportRlid { get; set; }

    public bool IsAdminCalculation { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowCito { get; set; }

    public bool IsAllowDiscount { get; set; }

    public bool IsPrintWithDoctorName { get; set; }

    public bool IsAssetUtilization { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? RlMasterReportItemId { get; set; }

    public virtual Item Item { get; set; }
}
