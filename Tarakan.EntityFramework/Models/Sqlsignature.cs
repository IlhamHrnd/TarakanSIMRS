using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Sqlsignature
{
    public int SqlsignatureId { get; set; }

    public string SqlsignatureHash { get; set; }

    public string Sqlsignature1 { get; set; }

    public bool? Overflow { get; set; }

    public int? SqlstatementExampleId { get; set; }

    public bool? DoNotAggregate { get; set; }

    public virtual ICollection<DeadlockProcess> DeadlockProcesses { get; set; } = new List<DeadlockProcess>();

    public virtual ICollection<QuerySignatureAggregation> QuerySignatureAggregations { get; set; } = new List<QuerySignatureAggregation>();

    public virtual SqlsignaturesOverflow SqlsignaturesOverflow { get; set; }

    public virtual Sqlstatement SqlstatementExample { get; set; }
}
