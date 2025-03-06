using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Block
{
    public Guid BlockId { get; set; }

    public long XactId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public string Xdldata { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }
}
