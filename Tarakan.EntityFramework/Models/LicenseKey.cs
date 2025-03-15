using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LicenseKey
{
    public Guid LicenseId { get; set; }

    public string LicenseKey1 { get; set; } = null!;

    public DateTime DateAddedUtc { get; set; }
}
