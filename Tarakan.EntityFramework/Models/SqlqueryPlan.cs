using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlqueryPlan
{
    public int PlanId { get; set; }

    public int? SqlstatementId { get; set; }

    public string? PlanXml { get; set; }

    public bool? Overflow { get; set; }

    public bool IsActualPlan { get; set; }

    public virtual SqlqueryPlansOverflow? SqlqueryPlansOverflow { get; set; }

    public virtual Sqlstatement? Sqlstatement { get; set; }
}
