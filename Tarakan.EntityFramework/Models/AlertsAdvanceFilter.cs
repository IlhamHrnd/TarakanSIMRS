using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AlertsAdvanceFilter
{
    public string FilterName { get; set; } = null!;

    public string Config { get; set; } = null!;
}
