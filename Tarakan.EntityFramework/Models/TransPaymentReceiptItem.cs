using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentReceiptItem
{
    public string PaymentReceiptNo { get; set; }

    public string PaymentNo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? Amount { get; set; }

    public virtual TransPayment PaymentNoNavigation { get; set; }

    public virtual TransPaymentReceipt PaymentReceiptNoNavigation { get; set; }
}
