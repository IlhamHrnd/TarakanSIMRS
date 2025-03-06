using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BankInquiryDetail
{
    public int TransactionId { get; set; }

    public int InquiryId { get; set; }

    public int? ReconcileId { get; set; }

    public string RelatedTransactionNo { get; set; }

    public DateTime TransactionDateTime { get; set; }

    public string Description { get; set; }

    public string ReferenceNo { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public decimal Balance { get; set; }

    public string SrcashTransactionCode { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
