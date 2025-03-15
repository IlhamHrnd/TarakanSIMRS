using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationPathway
{
    public string RegistrationNo { get; set; } = null!;

    public string PathwayId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? PathwayStatus { get; set; }

    public string? Notes { get; set; }
}
