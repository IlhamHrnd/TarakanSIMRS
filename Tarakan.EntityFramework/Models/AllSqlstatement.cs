using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AllSqlstatement
{
    public int SqlstatementId { get; set; }

    public string SqlstatementHash { get; set; }

    public string Sqlstatement { get; set; }
}
