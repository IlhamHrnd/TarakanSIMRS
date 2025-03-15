using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmDatum
{
    public string? PaymentNo { get; set; }

    public string? Kasir { get; set; }

    public string? Judul { get; set; }

    public decimal? Amount { get; set; }
}
