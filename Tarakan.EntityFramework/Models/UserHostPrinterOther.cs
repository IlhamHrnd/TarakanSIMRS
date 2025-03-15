using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class UserHostPrinterOther
{
    public string UserHostName { get; set; } = null!;

    public string ProgramId { get; set; } = null!;

    public string PrinterId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
