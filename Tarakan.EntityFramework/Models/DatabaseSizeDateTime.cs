using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseSizeDateTime
{
    public int DatabaseId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; } = null!;
}
