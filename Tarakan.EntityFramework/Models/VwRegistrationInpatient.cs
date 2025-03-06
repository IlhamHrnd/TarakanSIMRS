using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistrationInpatient
{
    public string RegistrationNo { get; set; }

    public string FromRegistrationNo { get; set; }

    public string PatientId { get; set; }

    public string GuarantorId { get; set; }

    public string ParamedicId { get; set; }
}
