using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientDischargeAppointment
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public DateTime? AppointmentDate { get; set; }

    public string? AppointmentTime { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? RoomId { get; set; }

    public string? QueNo { get; set; }

    public string? Notes { get; set; }

    public bool? IsProcessed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
