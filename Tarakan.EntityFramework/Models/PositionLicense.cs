using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionLicense
{
    public int PositionLicenseId { get; set; }

    public int PositionId { get; set; }

    public string Srrequirement { get; set; } = null!;

    public string SrlicenseType { get; set; } = null!;

    public string? LicenseNotes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
