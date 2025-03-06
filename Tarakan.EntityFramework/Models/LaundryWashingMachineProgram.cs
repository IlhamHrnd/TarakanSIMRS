using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryWashingMachineProgram
{
    public string MachineId { get; set; }

    public string SrlaundryProgram { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
