using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomReportsCounter
{
    public int Id { get; set; }

    public int GraphNumber { get; set; }

    public string CounterShortDescription { get; set; }

    public string CounterName { get; set; }

    public int? Aggregation { get; set; }

    public int? Source { get; set; }

    public virtual CustomReport IdNavigation { get; set; }
}
