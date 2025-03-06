using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MergeBillingHistory
{
    public string RegistrationNo { get; set; }

    public string FromRegistrationNoBefore { get; set; }

    public string FromRegistrationNoAfter { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
