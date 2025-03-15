using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Currency
{
    public string CurrencyId { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
