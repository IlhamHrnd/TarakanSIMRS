using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class UserHostPrinterOther
{
    public string UserHostName { get; set; }

    public string ProgramId { get; set; }

    public string PrinterId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
