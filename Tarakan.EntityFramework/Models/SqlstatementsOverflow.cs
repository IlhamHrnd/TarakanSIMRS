using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlstatementsOverflow
{
    public int SqlstatementId { get; set; }

    public string SqlstatementOverflow { get; set; }

    public virtual Sqlstatement Sqlstatement { get; set; }
}
