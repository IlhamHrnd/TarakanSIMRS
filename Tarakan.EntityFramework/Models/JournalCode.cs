using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class JournalCode
{
    public int JournalCodeId { get; set; }

    public string JournalCode1 { get; set; }

    public string Description { get; set; }

    public int CurrentNumber { get; set; }

    public string NumberFormat { get; set; }

    public int NumberSeed { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsAutoNumber { get; set; }

    public string BankId { get; set; }

    public string CashType { get; set; }

    public bool? IsVisible { get; set; }

    public bool? IsBku { get; set; }
}
