using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VDoktersoap
{
    public string ParamedicName { get; set; }

    public int? TotalReseps { get; set; }

    public int? TotalSoaps { get; set; }

    public string SrregistrationType { get; set; }
}
