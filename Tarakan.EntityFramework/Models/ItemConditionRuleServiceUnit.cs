using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemConditionRuleServiceUnit
{
    public string ItemConditionRuleId { get; set; }

    public string ServiceUnitId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
