using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseFile
{
    public int FileId { get; set; }

    public int DatabaseId { get; set; }

    public string? FileName { get; set; }

    public int? FileType { get; set; }

    public string? FilePath { get; set; }

    public string? DriveName { get; set; }

    public string? FileGroupName { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; } = null!;

    public virtual ICollection<DatabaseFileActivity> DatabaseFileActivities { get; set; } = new List<DatabaseFileActivity>();

    public virtual ICollection<DatabaseFileStatistic> DatabaseFileStatistics { get; set; } = new List<DatabaseFileStatistic>();

    public virtual ICollection<TempdbFileDatum> TempdbFileData { get; set; } = new List<TempdbFileDatum>();
}
