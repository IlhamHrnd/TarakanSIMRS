using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Therapy
{
    public string TherapyId { get; set; } = null!;

    public string TherapyName { get; set; } = null!;

    public string SrtherapyGroup { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
