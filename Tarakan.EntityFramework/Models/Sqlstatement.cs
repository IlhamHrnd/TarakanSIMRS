using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Sqlstatement
{
    public int SqlstatementId { get; set; }

    public string SqlstatementHash { get; set; }

    public string Sqlstatement1 { get; set; }

    public bool? Overflow { get; set; }

    public virtual ICollection<DeadlockProcess> DeadlockProcesses { get; set; } = new List<DeadlockProcess>();

    public virtual ICollection<SqlqueryPlan> SqlqueryPlans { get; set; } = new List<SqlqueryPlan>();

    public virtual ICollection<Sqlsignature> Sqlsignatures { get; set; } = new List<Sqlsignature>();

    public virtual SqlstatementsOverflow SqlstatementsOverflow { get; set; }
}
