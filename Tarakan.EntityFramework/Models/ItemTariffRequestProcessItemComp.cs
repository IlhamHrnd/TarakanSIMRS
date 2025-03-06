using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffRequestProcessItemComp
{
    public string TariffRequestNo { get; set; }

    public string TariffComponentId { get; set; }

    public decimal AmountValue { get; set; }

    public bool IsValueInPercent { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
