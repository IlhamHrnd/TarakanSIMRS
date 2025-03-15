using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistrationInpatient
{
    public string RegistrationNo { get; set; } = null!;

    public string FromRegistrationNo { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string GuarantorId { get; set; } = null!;

    public string? ParamedicId { get; set; }
}
