using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemRadiology
{
    public string ItemId { get; set; } = null!;

    public string ReportRlid { get; set; } = null!;

    public bool IsAdminCalculation { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowCito { get; set; }

    public bool IsAllowDiscount { get; set; }

    public bool IsPrintWithDoctorName { get; set; }

    public bool IsAssetUtilization { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public int? RlMasterReportItemId { get; set; }

    public bool? IsCitoFromStandardReference { get; set; }

    public int? ExpiredResultsInDays { get; set; }

    public virtual Item Item { get; set; } = null!;
}
