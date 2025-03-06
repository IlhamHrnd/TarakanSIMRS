using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BudgetingDetailItem
{
    public string BudgetingNo { get; set; }

    public int Revision { get; set; }

    public int ChartOfAccountId { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string AssetApprovedBy { get; set; }

    public DateTime? AssetApprovedDateTime { get; set; }

    public bool? IsAssetRejected { get; set; }

    public string AssetRejectedBy { get; set; }

    public DateTime? AssetRejectedDateTime { get; set; }

    public decimal? QtyMonth01 { get; set; }

    public decimal? QtyMonth02 { get; set; }

    public decimal? QtyMonth03 { get; set; }

    public decimal? QtyMonth04 { get; set; }

    public decimal? QtyMonth05 { get; set; }

    public decimal? QtyMonth06 { get; set; }

    public decimal? QtyMonth07 { get; set; }

    public decimal? QtyMonth08 { get; set; }

    public decimal? QtyMonth09 { get; set; }

    public decimal? QtyMonth10 { get; set; }

    public decimal? QtyMonth11 { get; set; }

    public decimal? QtyMonth12 { get; set; }

    public decimal? Price { get; set; }

    public bool? IsAssetApproved { get; set; }

    public bool? IsAsset { get; set; }

    public string RejectNotes { get; set; }

    public decimal? ConversionFactor { get; set; }
}
