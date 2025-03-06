using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TableReorganization
{
    public int TableId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public double? ScanDensity { get; set; }

    public double? LogicalFragmentation { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public virtual SqlserverTableName Table { get; set; }
}
