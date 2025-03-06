using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SupplierBank
{
    public string SupplierId { get; set; }

    public string BankAccountNo { get; set; }

    public string BankName { get; set; }

    public string BankAccountName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
