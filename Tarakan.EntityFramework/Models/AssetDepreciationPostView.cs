using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetDepreciationPostView
{
    public int AssetDepreciationPostId { get; set; }

    public string AssetGroupId { get; set; }

    public string GroupName { get; set; }

    public string AssetId { get; set; }

    public string AssetName { get; set; }

    public string SerialNumber { get; set; }

    public int PeriodNo { get; set; }

    public string Year { get; set; }

    public string Month { get; set; }

    public decimal DepreciationAmount { get; set; }

    public bool IsPosted { get; set; }

    public int? JournalId { get; set; }

    public int AssetAccumulationAccountId { get; set; }

    public int AssetAccumulationSubLedgerId { get; set; }

    public int AssetCostAccountId { get; set; }

    public int AssetCostSubLedgerId { get; set; }
}
