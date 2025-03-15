using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorItemPrescriptionRule
{
    public string GuarantorId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? SrguarantorRuleType { get; set; }

    public decimal AmountValue { get; set; }

    public bool IsValueInPercent { get; set; }

    public bool IsInclude { get; set; }

    public bool? IsToGuarantor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }
}
