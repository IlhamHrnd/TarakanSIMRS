using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TempdbFileDatum
{
    public int FileId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public long? FileSizeInKilobytes { get; set; }

    public long? UserObjectsInKilobytes { get; set; }

    public long? InternalObjectsInKilobytes { get; set; }

    public long? VersionStoreInKilobytes { get; set; }

    public long? MixedExtentsInKilobytes { get; set; }

    public long? UnallocatedSpaceInKilobytes { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public virtual DatabaseFile File { get; set; }
}
