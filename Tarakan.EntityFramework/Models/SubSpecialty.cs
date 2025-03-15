using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SubSpecialty
{
    public string SubSpecialtyId { get; set; } = null!;

    public string Srspecialty { get; set; } = null!;

    public string SubSpecialtyName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
