using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MergeBilling
{
    public string RegistrationNo { get; set; } = null!;

    public string FromRegistrationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
