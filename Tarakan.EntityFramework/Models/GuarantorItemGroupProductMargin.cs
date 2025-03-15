using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorItemGroupProductMargin
{
    public string GuarantorId { get; set; } = null!;

    public string ItemGroupId { get; set; } = null!;

    public decimal MarginPercentage { get; set; }

    public string MarginId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
