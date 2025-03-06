using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ChartOfAccount
{
    public string ChartOfAccountCode { get; set; }

    public string ChartOfAccountName { get; set; }

    public bool IsDetail { get; set; }

    public int AccountLevel { get; set; }

    public string GeneralAccount { get; set; }

    public string NormalBalance { get; set; }

    public int AccountGroup { get; set; }

    public int? SubLedgerId { get; set; }

    public bool IsDocumenNumberEnabled { get; set; }

    public string TreeCode { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsActive { get; set; }

    public bool IsControlDocNumber { get; set; }

    public string Note { get; set; }

    public int ChartOfAccountId { get; set; }

    public bool? IsReconcile { get; set; }

    public int? BkuAccountId { get; set; }

    public bool? IsBku { get; set; }

    public virtual ICollection<ChartOfAccountBalance> ChartOfAccountBalances { get; set; } = new List<ChartOfAccountBalance>();

    public virtual ICollection<JournalTransactionDetail> JournalTransactionDetails { get; set; } = new List<JournalTransactionDetail>();

    public virtual ICollection<SubLedgerBalance> SubLedgerBalances { get; set; } = new List<SubLedgerBalance>();
}
