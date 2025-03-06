using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppointmentSlot
{
    public string AppointmentNo { get; set; }

    public string SlotId { get; set; }

    public bool? IsActive { get; set; }
}
