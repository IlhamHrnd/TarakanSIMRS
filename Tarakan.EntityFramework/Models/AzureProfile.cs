using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AzureProfile
{
    public long Id { get; set; }

    public long AzureApplicationProfileId { get; set; }

    public int SqlserverId { get; set; }

    public string? Description { get; set; }

    public virtual AzureApplicationProfile AzureApplicationProfile { get; set; } = null!;

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
