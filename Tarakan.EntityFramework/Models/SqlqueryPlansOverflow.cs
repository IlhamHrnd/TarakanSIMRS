using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlqueryPlansOverflow
{
    public int PlanId { get; set; }

    public string? PlanXmloverflow { get; set; }

    public virtual SqlqueryPlan Plan { get; set; } = null!;
}
