using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TableGrowthAggregation
{
    public long AggregatedTableId { get; set; }

    public DateTime MinUtccollectionDateTime { get; set; }

    public DateTime MaxUtccollectionDateTime { get; set; }

    public long? MinNumberOfRows { get; set; }

    public long? MaxNumberOfRows { get; set; }

    public long? TotalNumberOfRows { get; set; }

    public long? MinDataSize { get; set; }

    public long? MaxDataSize { get; set; }

    public long? TotalDataSize { get; set; }

    public long? MinTextSize { get; set; }

    public long? MaxTextSize { get; set; }

    public long? TotalTextSize { get; set; }

    public long? MinIndexSize { get; set; }

    public long? MaxIndexSize { get; set; }

    public long? TotalIndexSize { get; set; }

    public long? MinTimeDeltaInSeconds { get; set; }

    public long? MaxTimeDeltaInSeconds { get; set; }

    public long? TotalTimeDeltaInSeconds { get; set; }

    public int TableId { get; set; }
}
