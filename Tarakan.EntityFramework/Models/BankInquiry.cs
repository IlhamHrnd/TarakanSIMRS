using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BankInquiry
{
    public int InquiryId { get; set; }

    public string BankId { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string FileName { get; set; } = null!;
}
