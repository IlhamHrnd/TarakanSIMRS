using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpBank
{
    public string? BankId { get; set; }

    public string? BankName { get; set; }

    public double? ChartOfAccountId { get; set; }

    public double? SubledgerId { get; set; }

    public string? JournalCode { get; set; }

    public string? CurrencyCode { get; set; }

    public double? IsActive { get; set; }

    public double? IsToBeCleared { get; set; }

    public double? IsCrossRefference { get; set; }
}
