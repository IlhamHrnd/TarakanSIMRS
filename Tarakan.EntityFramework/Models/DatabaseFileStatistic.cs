using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseFileStatistic
{
    public int FileStatisticsId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public int FileId { get; set; }

    public decimal? MaxSize { get; set; }

    public decimal? InitialSize { get; set; }

    public decimal? UsedSpace { get; set; }

    public decimal? AvailableSpace { get; set; }

    public decimal? FreeDiskSpace { get; set; }

    public string DriveName { get; set; }

    public virtual DatabaseFile File { get; set; }
}
