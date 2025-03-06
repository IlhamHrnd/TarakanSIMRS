using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class KemenkesSitb
{
    public string RegistrationNo { get; set; }

    public string SitbNo { get; set; }

    public string RequestSitb { get; set; }

    public string ResponseSitb { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
