using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistrationque
{
    public string MedicalNo { get; set; }

    public string PatientName { get; set; }

    public string ParamedicId { get; set; }

    public string ParamedicName { get; set; }

    public string ServiceUnitName { get; set; }

    public string RoomName { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; }

    public int? RegistrationQue { get; set; }

    public bool? IsVoid { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }
}
