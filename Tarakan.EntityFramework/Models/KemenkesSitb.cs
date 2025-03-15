using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class KemenkesSitb
{
    public string RegistrationNo { get; set; } = null!;

    public string SitbNo { get; set; } = null!;

    public string RequestSitb { get; set; } = null!;

    public string ResponseSitb { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
