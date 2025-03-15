using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseFileActivity
{
    public int FileId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public long? Reads { get; set; }

    public long? Writes { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public virtual DatabaseFile File { get; set; } = null!;
}
