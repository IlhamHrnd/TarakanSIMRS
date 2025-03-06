using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppAutoNumberTransactionCode
{
    public string SrtransactionCode { get; set; }

    public string SrautoNumber { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
