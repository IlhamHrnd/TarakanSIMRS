using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AuditableEvent
{
    public long AuditableEventId { get; set; }

    public int ActionId { get; set; }

    public DateTime DateTime { get; set; }

    public string Workstation { get; set; }

    public string WorkstationUser { get; set; }

    public string Sqluser { get; set; }

    public string Name { get; set; }

    public string MetaData { get; set; }

    public string Header { get; set; }
}
