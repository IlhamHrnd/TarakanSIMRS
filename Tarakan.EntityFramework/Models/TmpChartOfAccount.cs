using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpChartOfAccount
{
    public string NoPerkiraan { get; set; }

    public string NamaPerkiraan { get; set; }

    public double? Level { get; set; }

    public string Type { get; set; }

    public double? IsDetail { get; set; }

    public string GeneralAccount { get; set; }

    public double? GroupAcct { get; set; }

    public string SaldoNormal { get; set; }

    public double? ChartOfAccountId { get; set; }
}
