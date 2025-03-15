using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppAutoNumberTransactionCode
{
    public string SrtransactionCode { get; set; } = null!;

    public string SrautoNumber { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
