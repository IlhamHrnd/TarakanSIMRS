using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationInfo
{
    public string RegistrationInfoId { get; set; }

    public string RegistrationNo { get; set; }

    public string Information { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; }
}
