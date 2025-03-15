using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwClosedRegistration
{
    public string RegistrationNo { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public string? ParamedicId { get; set; }

    public string PatientId { get; set; } = null!;

    public string? RoomId { get; set; }

    public string? BedId { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string ParamedicIdreferral { get; set; } = null!;
}
