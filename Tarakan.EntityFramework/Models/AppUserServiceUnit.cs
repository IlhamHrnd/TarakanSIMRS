using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserServiceUnit
{
    public string UserId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public bool? IsDiscontinue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
