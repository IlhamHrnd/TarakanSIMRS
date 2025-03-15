using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemService
{
    public string ItemId { get; set; } = null!;

    public string ReportRlid { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public bool? IsPrimaryService { get; set; }

    public bool IsAdminCalculation { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowCito { get; set; }

    public bool IsAllowDiscount { get; set; }

    public bool IsPrintWithDoctorName { get; set; }

    public bool IsAssetUtilization { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? PremiAmount { get; set; }

    public decimal? Premi2Amount { get; set; }

    public decimal? ProductionServicesPercentage { get; set; }

    public decimal? TogethernessPercentage { get; set; }

    public decimal? ProductionServicesPercentage2 { get; set; }

    public string? ItemRelatedId { get; set; }

    public decimal? QtyDivider { get; set; }

    public int? RlMasterReportItemId { get; set; }

    public bool? IsCitoFromStandardReference { get; set; }

    public virtual Item Item { get; set; } = null!;
}
