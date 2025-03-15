using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwPatientsPaidOff
{
    public string RegistrationNo { get; set; } = null!;

    public bool? IsPaidOff { get; set; }
}
