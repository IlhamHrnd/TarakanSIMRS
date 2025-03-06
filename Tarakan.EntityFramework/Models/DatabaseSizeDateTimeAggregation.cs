using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseSizeDateTimeAggregation
{
    public long AggregatedDatabaseId { get; set; }

    public DateTime MinUtccollectionDateTime { get; set; }

    public DateTime MaxUtccollectionDateTime { get; set; }

    public int DatabaseId { get; set; }
}
