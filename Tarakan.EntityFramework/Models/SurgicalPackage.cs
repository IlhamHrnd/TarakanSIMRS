using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SurgicalPackage
{
    public string PackageId { get; set; } = null!;

    public string PackageName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
