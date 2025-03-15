using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicScheduleSlot
{
    public string SlotId { get; set; } = null!;

    public DateTime? Begin { get; set; }

    public DateTime? End { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public int? Quota { get; set; }
}
