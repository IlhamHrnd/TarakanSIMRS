using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BaselineTemplate
{
    public int TemplateId { get; set; }

    public int SqlserverId { get; set; }

    public string Template { get; set; } = null!;

    public string BaselineName { get; set; } = null!;

    public bool Active { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
