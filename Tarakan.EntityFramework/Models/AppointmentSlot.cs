using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppointmentSlot
{
    public string AppointmentNo { get; set; } = null!;

    public string SlotId { get; set; } = null!;

    public bool? IsActive { get; set; }
}
