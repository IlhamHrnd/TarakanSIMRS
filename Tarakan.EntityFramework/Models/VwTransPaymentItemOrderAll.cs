using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransPaymentItemOrderAll
{
    public string PaymentNo { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool IsPaymentProceed { get; set; }

    public bool IsPaymentReturned { get; set; }

    public string JournalIncomePaymentNo { get; set; }

    public DateTime PaymentDate { get; set; }

    public string SrfilmId { get; set; }

    public decimal? QtyF { get; set; }
}
