using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PcareReference
{
    public string ReferenceId { get; set; } = null!;

    public string? ReferenceName { get; set; }

    public string? Url { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
