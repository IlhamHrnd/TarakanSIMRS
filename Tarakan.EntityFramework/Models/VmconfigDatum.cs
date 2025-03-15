using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VmconfigDatum
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public string? Uuid { get; set; }

    public string? Vmname { get; set; }

    public int? VmheartBeat { get; set; }

    public string? DomainName { get; set; }

    public DateTime? BootTime { get; set; }

    public int? NumCpus { get; set; }

    public long? Cpulimit { get; set; }

    public long? Cpureserve { get; set; }

    public long? MemSize { get; set; }

    public long? MemLimit { get; set; }

    public long? MemReserve { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
