using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InvoiceAdjusment
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string SupplierGuarantor { get; set; }

    public string Type { get; set; }

    public decimal Amount { get; set; }

    public string Reason { get; set; }

    public bool IsApproved { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string InvoicePaymentNo { get; set; }

    public decimal? PaymentAmount { get; set; }

    public decimal? OtherCost { get; set; }

    public decimal? BankCost { get; set; }
}
