using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SanitationWasteTransItem
{
    public string TransactionNo { get; set; }

    public string SrwasteType { get; set; }

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
