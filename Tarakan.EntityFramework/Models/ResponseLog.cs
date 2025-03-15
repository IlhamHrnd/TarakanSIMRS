using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ResponseLog
{
    public long Id { get; set; }

    public string? Datakirim { get; set; }

    public string? Dataquery { get; set; }

    public DateTime? Date { get; set; }
}
