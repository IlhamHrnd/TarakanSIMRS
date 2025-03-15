using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TableGrowth
{
    public int TableId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public long? NumberOfRows { get; set; }

    public double? DataSize { get; set; }

    public double? TextSize { get; set; }

    public double? IndexSize { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public virtual SqlserverTableName Table { get; set; } = null!;
}
