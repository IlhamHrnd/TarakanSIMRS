using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PastTransfusionHistory
{
    public string PatientId { get; set; } = null!;

    public string? Year { get; set; }

    public string? AllergicReaction { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
