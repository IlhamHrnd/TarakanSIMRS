using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CashMutation
{
    public int CashMutationId { get; set; }

    public int TransactionId { get; set; }

    public int? JournalId { get; set; }

    public string JournalNumber { get; set; }

    public string BankId { get; set; }

    public int BankChartOfAccountId { get; set; }

    public DateTime TransactionDate { get; set; }

    public string TransactionType { get; set; }

    public string PaymentType { get; set; }

    public string PaymentMethod { get; set; }

    public string NormalBalance { get; set; }

    public string Module { get; set; }

    public string CurrencyCode { get; set; }

    public decimal CurrencyRate { get; set; }

    public string ChequeNumber { get; set; }

    public string DocumentNumber { get; set; }

    public int DetailId { get; set; }

    public int ChartOfAccountId { get; set; }

    public int SubLedgerId { get; set; }

    public int CostCenterId { get; set; }

    public decimal Amount { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string Description { get; set; }

    public string DescriptionDetail { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int CashMutationType { get; set; }
}
