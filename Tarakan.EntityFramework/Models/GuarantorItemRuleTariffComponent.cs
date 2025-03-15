using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorItemRuleTariffComponent
{
    public string GuarantorId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public decimal AmountValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }
}
