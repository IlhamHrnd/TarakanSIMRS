using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MergeBillingHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string FromRegistrationNoBefore { get; set; } = null!;

    public string FromRegistrationNoAfter { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
