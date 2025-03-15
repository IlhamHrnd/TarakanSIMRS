using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionPersonal
{
    public int PositionPersonalId { get; set; }

    public int PositionId { get; set; }

    public int? MinimumAge { get; set; }

    public int? MaxsimumAge { get; set; }

    public string? SrmaritalStatus { get; set; }

    public string? SrgenderType { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
