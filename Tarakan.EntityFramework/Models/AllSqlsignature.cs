using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AllSqlsignature
{
    public int SqlsignatureId { get; set; }

    public string SqlsignatureHash { get; set; } = null!;

    public string? Sqlsignature { get; set; }

    public string? SqlstatementExample { get; set; }

    public bool? DoNotAggregate { get; set; }
}
