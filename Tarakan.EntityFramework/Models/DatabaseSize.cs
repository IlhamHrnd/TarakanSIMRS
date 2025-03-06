using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseSize
{
    public long DatabaseSizeId { get; set; }

    public int DatabaseId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public int? DatabaseStatus { get; set; }

    public decimal? DataFileSizeInKilobytes { get; set; }

    public decimal? LogFileSizeInKilobytes { get; set; }

    public decimal? DataSizeInKilobytes { get; set; }

    public decimal? LogSizeInKilobytes { get; set; }

    public decimal? TextSizeInKilobytes { get; set; }

    public decimal? IndexSizeInKilobytes { get; set; }

    public decimal? LogExpansionInKilobytes { get; set; }

    public decimal? DataExpansionInKilobytes { get; set; }

    public double? PercentLogSpace { get; set; }

    public double? PercentDataSize { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public DateTime? DatabaseStatisticsTime { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }
}
