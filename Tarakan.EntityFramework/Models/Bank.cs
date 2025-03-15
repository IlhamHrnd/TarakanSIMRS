using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Bank
{
    public string BankId { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? NoRek { get; set; }

    public string? JournalCode { get; set; }

    public string? CurrencyCode { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsToBeCleared { get; set; }

    public bool? IsCrossRefference { get; set; }

    public bool? IsCashierFrontOffice { get; set; }

    public bool? IsArPayment { get; set; }

    public bool? IsApPayment { get; set; }

    public bool? IsFeePayment { get; set; }

    public bool? IsBku { get; set; }

    public bool? IsCashierFrontOfficeDpReturn { get; set; }

    public bool? IsAssetAuctionPayment { get; set; }

    public virtual ICollection<BankAccountBalance> BankAccountBalances { get; set; } = new List<BankAccountBalance>();

    public virtual ICollection<CashTransaction> CashTransactions { get; set; } = new List<CashTransaction>();
}
