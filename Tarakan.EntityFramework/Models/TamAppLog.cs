using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TamAppLog
{
    public string RegistrationNo { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string? AppointmentNo { get; set; }

    public DateOnly PrintDate { get; set; }

    public TimeOnly PrintTime { get; set; }

    public string Location { get; set; } = null!;

    public int PrintCount { get; set; }
}
