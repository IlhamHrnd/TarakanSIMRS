using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlsignaturesOverflow
{
    public int SqlsignatureId { get; set; }

    public string SqlsignatureOverflow { get; set; }

    public virtual Sqlsignature Sqlsignature { get; set; }
}
