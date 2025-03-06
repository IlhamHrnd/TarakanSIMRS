using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdMachineItem
{
    public string MachineId { get; set; }

    public string SrcssdProcessType { get; set; }

    public short Duration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
