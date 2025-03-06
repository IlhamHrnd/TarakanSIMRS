using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorItemRuleTariffComponent
{
    public string GuarantorId { get; set; }

    public string ItemId { get; set; }

    public string TariffComponentId { get; set; }

    public decimal AmountValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }
}
