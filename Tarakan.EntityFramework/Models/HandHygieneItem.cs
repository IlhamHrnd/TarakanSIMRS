using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HandHygieneItem
{
    public string TransactionNo { get; set; } = null!;

    public string Sropportunity { get; set; } = null!;

    public string SrhandWashType { get; set; } = null!;

    public bool IsWearGloves { get; set; }

    public string SrhandHygieneNote { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsApply6Steps { get; set; }

    public string? Srapply6StepsResult { get; set; }
}
