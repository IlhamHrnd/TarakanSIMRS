using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CounterMasterList
{
    public int Id { get; set; }

    public string CounterName { get; set; }

    public string CounterFriendlyName { get; set; }

    public int? CounterType { get; set; }

    public bool? AvailableInCustomReport { get; set; }
}
