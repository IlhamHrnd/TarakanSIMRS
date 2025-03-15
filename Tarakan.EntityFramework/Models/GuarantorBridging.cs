using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorBridging
{
    public string GuarantorId { get; set; } = null!;

    public string SrbridgingType { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsPercentageCoverageValue { get; set; }

    public decimal? CoverageValue { get; set; }

    public decimal? MarginValue { get; set; }

    public string BridgingId { get; set; } = null!;

    public string? BridgingCode { get; set; }
}
