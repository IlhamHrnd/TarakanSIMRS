using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WageBase
{
    public int WageBaseId { get; set; }

    public DateTime ValidFrom { get; set; }

    public decimal Nominal { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
