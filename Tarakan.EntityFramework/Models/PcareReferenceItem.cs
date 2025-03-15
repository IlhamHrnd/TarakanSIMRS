using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PcareReferenceItem
{
    public string ReferenceId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? ResponseData { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
