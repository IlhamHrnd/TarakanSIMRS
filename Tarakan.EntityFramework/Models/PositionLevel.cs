using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionLevel
{
    public int PositionLevelId { get; set; }

    public string PositionLevelCode { get; set; } = null!;

    public string PositionLevelName { get; set; } = null!;

    public short Ranking { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
