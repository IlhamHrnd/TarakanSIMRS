using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CurrencyRate
{
    public string CurrencyId { get; set; }

    public string CurrencyName { get; set; }

    public decimal CurrencyRate1 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
