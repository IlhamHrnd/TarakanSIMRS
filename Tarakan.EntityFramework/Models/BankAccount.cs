using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BankAccount
{
    public string BankId { get; set; }

    public string BankAccountNo { get; set; }

    public string Srcurrency { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
