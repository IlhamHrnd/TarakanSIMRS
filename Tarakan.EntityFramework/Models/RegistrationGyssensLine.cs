using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationGyssensLine
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public string RasproLineId { get; set; } = null!;

    public string? Condition { get; set; }

    public string? GyssensCategory { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
