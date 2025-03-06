using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InvoiceSupplierItemConsignment
{
    public string InvoiceNo { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
