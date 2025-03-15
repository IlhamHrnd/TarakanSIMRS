using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpBillIntermLog
{
    public string? RegistrationNo { get; set; }

    public DateTime? ExecDate { get; set; }

    public string? Region { get; set; }

    public DateTime? Tic { get; set; }

    public DateTime? Toc { get; set; }

    public int? Secs { get; set; }
}
