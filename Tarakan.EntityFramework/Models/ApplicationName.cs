using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicationName
{
    public int ApplicationNameId { get; set; }

    public string ApplicationName1 { get; set; }

    public virtual ICollection<DeadlockProcess> DeadlockProcesses { get; set; } = new List<DeadlockProcess>();

    public virtual ICollection<QuerySignatureAggregation> QuerySignatureAggregations { get; set; } = new List<QuerySignatureAggregation>();
}
