using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistrationque
{
    public string? MedicalNo { get; set; }

    public string? PatientName { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; } = null!;

    public int? RegistrationQue { get; set; }

    public bool? IsVoid { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string RoomId { get; set; } = null!;
}
