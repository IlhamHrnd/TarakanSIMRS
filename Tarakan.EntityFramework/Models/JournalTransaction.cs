using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class JournalTransaction
{
    public int JournalId { get; set; }

    public string JournalCode { get; set; }

    public string JournalType { get; set; }

    public string TransactionNumber { get; set; }

    public DateTime TransactionDate { get; set; }

    public string Description { get; set; }

    public bool IsPosted { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool IsVoid { get; set; }

    public DateTime VoidDate { get; set; }

    public string RefferenceNumber { get; set; }

    public int? JournalIdRefference { get; set; }

    public string BudgetingCode { get; set; }

    public DateTime? DatePosted { get; set; }

    public string SysPostedBy { get; set; }

    public virtual JournalMessage JournalMessage { get; set; }

    public virtual ICollection<JournalTransactionDetail> JournalTransactionDetails { get; set; } = new List<JournalTransactionDetail>();
}
