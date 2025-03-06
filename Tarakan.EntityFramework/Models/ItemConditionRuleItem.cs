using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemConditionRuleItem
{
    public string ItemConditionRuleId { get; set; }

    public string ItemId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
