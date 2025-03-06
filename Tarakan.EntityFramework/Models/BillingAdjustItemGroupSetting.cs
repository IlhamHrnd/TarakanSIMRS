using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BillingAdjustItemGroupSetting
{
    public string ItemGroupId { get; set; }

    public decimal DiscValue { get; set; }

    public int DiscSelection { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
