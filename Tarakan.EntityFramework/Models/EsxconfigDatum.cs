using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EsxconfigDatum
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public string? Uuid { get; set; }

    public string? HostName { get; set; }

    public string? DomainName { get; set; }

    public int? Status { get; set; }

    public DateTime? BootTime { get; set; }

    public int? Cpumhz { get; set; }

    public short? NumCpucores { get; set; }

    public short? NumCpupkgs { get; set; }

    public short? NumCputhreads { get; set; }

    public int? NumNics { get; set; }

    public long? MemorySize { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
