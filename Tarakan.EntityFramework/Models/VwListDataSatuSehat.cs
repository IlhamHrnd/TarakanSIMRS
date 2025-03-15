using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwListDataSatuSehat
{
    public string RegistrationNo { get; set; } = null!;

    public string? EncounterId { get; set; }

    public string PatientId { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public string? ParamedicId { get; set; }
}
