using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetGroup
{
    public string AssetGroupId { get; set; }

    public string GroupName { get; set; }

    public string Description { get; set; }

    public string Initial { get; set; }

    public bool IsActive { get; set; }

    public int AssetAccountId { get; set; }

    public int AssetSubLedgerId { get; set; }

    public int AssetAccumulationAccountId { get; set; }

    public int AssetAccumulationSubLedgerId { get; set; }

    public int AssetCostAccountId { get; set; }

    public int AssetCostSubLedgerId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? AssetCostDestructionAccountId { get; set; }

    public int? AssetCostDestructionSubLedgerId { get; set; }
}
