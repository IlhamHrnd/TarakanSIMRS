using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdMachineItem
{
    public string MachineId { get; set; } = null!;

    public string SrcssdProcessType { get; set; } = null!;

    public short Duration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
