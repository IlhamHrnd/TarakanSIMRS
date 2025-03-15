using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationDisplayEmergency
{
    public string? Ip { get; set; }

    public string? ServiceUnitId { get; set; }

    public int? CurrentPage { get; set; }
}
