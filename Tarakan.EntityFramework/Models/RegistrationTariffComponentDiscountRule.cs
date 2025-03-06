using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationTariffComponentDiscountRule
{
    public string RegistrationNo { get; set; }

    public string TariffComponentId { get; set; }

    public bool? IsDiscountInPercentage { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
