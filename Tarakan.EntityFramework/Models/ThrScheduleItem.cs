using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ThrScheduleItem
{
    public int CounterItemId { get; set; }

    public int CounterId { get; set; }

    public string Srreligion { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
