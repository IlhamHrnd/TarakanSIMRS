using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseSizeAggregation
{
    public long AggregatedDatabaseSizeId { get; set; }

    public int DatabaseId { get; set; }

    public DateTime MinUtccollectionDateTime { get; set; }

    public DateTime MaxUtccollectionDateTime { get; set; }

    public decimal? MinDataFileSizeInKilobytes { get; set; }

    public decimal? MaxDataFileSizeInKilobytes { get; set; }

    public decimal? TotalDataFileSizeInKilobytes { get; set; }

    public int? DatabaseStatus { get; set; }

    public decimal? MinLogFileSizeInKilobytes { get; set; }

    public decimal? MaxLogFileSizeInKilobytes { get; set; }

    public decimal? TotalLogFileSizeInKilobytes { get; set; }

    public decimal? MinDataSizeInKilobytes { get; set; }

    public decimal? MaxDataSizeInKilobytes { get; set; }

    public decimal? TotalDataSizeInKilobytes { get; set; }

    public decimal? MinLogSizeInKilobytes { get; set; }

    public decimal? MaxLogSizeInKilobytes { get; set; }

    public decimal? TotalLogSizeInKilobytes { get; set; }

    public decimal? MinTextSizeInKilobytes { get; set; }

    public decimal? MaxTextSizeInKilobytes { get; set; }

    public decimal? TotalTextSizeInKilobytes { get; set; }

    public decimal? MinIndexSizeInKilobytes { get; set; }

    public decimal? MaxIndexSizeInKilobytes { get; set; }

    public decimal? TotalIndexSizeInKilobytes { get; set; }

    public decimal? MinLogExpansionInKilobytes { get; set; }

    public decimal? MaxLogExpansionInKilobytes { get; set; }

    public decimal? TotalLogExpansionInKilobytes { get; set; }

    public decimal? MinDataExpansionInKilobytes { get; set; }

    public decimal? MaxDataExpansionInKilobytes { get; set; }

    public decimal? TotalDataExpansionInKilobytes { get; set; }

    public decimal? MinPercentLogSpace { get; set; }

    public decimal? MaxPercentLogSpace { get; set; }

    public decimal? TotalPercentLogSpace { get; set; }

    public decimal? MinPercentDataSize { get; set; }

    public decimal? MaxPercentDataSize { get; set; }

    public decimal? TotalPercentDataSize { get; set; }

    public long? MinTimeDeltaInSeconds { get; set; }

    public long? MaxTimeDeltaInSeconds { get; set; }

    public long? TotalTimeDeltaInSeconds { get; set; }

    public DateTime? MinDatabaseStatisticsTime { get; set; }

    public DateTime? MaxDatabaseStatisticsTime { get; set; }
}
