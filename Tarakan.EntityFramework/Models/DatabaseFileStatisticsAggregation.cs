using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseFileStatisticsAggregation
{
    public long AggregatedFileStatisticsId { get; set; }

    public DateTime? MinUtccollectionDateTime { get; set; }

    public DateTime? MaxUtccollectionDateTime { get; set; }

    public int? FileId { get; set; }

    public decimal? MinMaxSize { get; set; }

    public decimal? MaxMaxSize { get; set; }

    public decimal? TotalMaxSize { get; set; }

    public decimal? MinInitialSize { get; set; }

    public decimal? MaxInitialSize { get; set; }

    public decimal? TotalInitialSize { get; set; }

    public decimal? MinUsedSpace { get; set; }

    public decimal? MaxUsedSpace { get; set; }

    public decimal? TotalUsedSpace { get; set; }

    public decimal? MinAvailableSpace { get; set; }

    public decimal? MaxAvailableSpace { get; set; }

    public decimal? TotalAvailableSpace { get; set; }

    public decimal? MinFreeDiskSpace { get; set; }

    public decimal? MaxFreeDiskSpace { get; set; }

    public decimal? TotalFreeDiskSpace { get; set; }

    public string DriveName { get; set; }
}
