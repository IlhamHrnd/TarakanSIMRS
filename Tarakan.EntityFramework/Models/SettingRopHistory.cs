using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SettingRopHistory
{
    public Guid RopHistoryId { get; set; }

    public DateTime RopHistoryDateTime { get; set; }

    public string LocationId { get; set; }

    public string ItemId { get; set; }

    public decimal FromMinimum { get; set; }

    public decimal ToMinimum { get; set; }

    public decimal FromMaximum { get; set; }

    public decimal ToMaximum { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
