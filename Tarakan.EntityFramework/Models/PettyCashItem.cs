using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PettyCashItem
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string Description { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }
}
