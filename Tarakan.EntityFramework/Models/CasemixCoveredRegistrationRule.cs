using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CasemixCoveredRegistrationRule
{
    public string RegistrationNo { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
