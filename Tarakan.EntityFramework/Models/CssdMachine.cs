using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdMachine
{
    public string MachineId { get; set; } = null!;

    public string MachineName { get; set; } = null!;

    public DateTime StartUsingDate { get; set; }

    public decimal Volume { get; set; }

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
