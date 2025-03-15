using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationTariffComponentDiscountRule
{
    public string RegistrationNo { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public bool? IsDiscountInPercentage { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
