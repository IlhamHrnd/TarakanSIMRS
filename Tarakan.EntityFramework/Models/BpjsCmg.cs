using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsCmg
{
    public string NoSep { get; set; }

    public string KodeCmg { get; set; }

    public decimal? TariffCmg { get; set; }

    public string DeskripsiCmg { get; set; }

    public string TipeCmg { get; set; }

    public bool? IsOptionCmg { get; set; }
}
