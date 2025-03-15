using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMarginValue
{
    public string MarginId { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public decimal StartingValue { get; set; }

    public decimal EndingValue { get; set; }

    public decimal MarginPercentage { get; set; }

    public bool IsMinusDiscount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? OtcmarginPercentage { get; set; }

    public decimal? OutpatientMarginPercentage { get; set; }

    public decimal? InpatientMarginPercentage { get; set; }

    public bool? IsGlobalWithoutVat { get; set; }

    public bool? IsIpWithoutVat { get; set; }

    public bool? IsOpWithoutVat { get; set; }

    public bool? IsOtcWithoutVat { get; set; }

    public decimal? EmergencyMarginPercentage { get; set; }

    public bool? IsEmWithoutVat { get; set; }

    public virtual ItemProductMargin Margin { get; set; } = null!;
}
