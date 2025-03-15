using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemConditionRule
{
    public string ItemConditionRuleId { get; set; } = null!;

    public string ItemConditionRuleName { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public DateTime EndingDate { get; set; }

    public string SritemConditionRuleType { get; set; } = null!;

    public bool IsValueInPercent { get; set; }

    public decimal AmountValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
