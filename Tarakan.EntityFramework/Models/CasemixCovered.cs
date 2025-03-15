using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CasemixCovered
{
    public int CasemixCoveredId { get; set; }

    public string? CasemixCoveredName { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
