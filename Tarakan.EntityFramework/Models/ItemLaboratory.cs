using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemLaboratory
{
    public string ItemId { get; set; } = null!;

    public string ReportRlid { get; set; } = null!;

    public bool IsAdminCalculation { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowCito { get; set; }

    public bool IsAllowDiscount { get; set; }

    public bool IsAssetUtilization { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsDisplayInOrderList { get; set; }

    public int? RlMasterReportItemId { get; set; }

    public string? SrexaminationClass { get; set; }

    public string? SrlaboratoryUnit { get; set; }

    public int? LevelNo { get; set; }

    public int? DisplaySequence { get; set; }

    public bool? IsConfidential { get; set; }

    public bool? IsResultOnSepataredPage { get; set; }

    public bool? IsCitoFromStandardReference { get; set; }

    public short? WaitingTimeForResults { get; set; }

    public string? SrintervalTime { get; set; }

    public string? SrspecimenType { get; set; }

    public bool? IsCulture { get; set; }

    public int? ExpiredResultsInDays { get; set; }

    public virtual Item Item { get; set; } = null!;
}
