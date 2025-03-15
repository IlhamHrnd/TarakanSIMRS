using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwHistoryRegistration
{
    public string RegistrationNo { get; set; } = null!;

    public string? AppointmentNo { get; set; }

    public string? ParamedicId { get; set; }

    public string PatientId { get; set; } = null!;

    public string MedicalNo { get; set; } = null!;

    public string? PatientName { get; set; }

    public string ParamedicName { get; set; } = null!;

    public string ParamedicInitial { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; } = null!;

    public string? LastCreateUserId { get; set; }

    public string GuarantorName { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;

    public string? AppointmentTimeConvert { get; set; }

    public string Weekdays { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public int? RegistrationQue { get; set; }
}
