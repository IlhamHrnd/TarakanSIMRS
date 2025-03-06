using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransactionItem
{
    public int TxType { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ParamedicCollectionName { get; set; }
}
