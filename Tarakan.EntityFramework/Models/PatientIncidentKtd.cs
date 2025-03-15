using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentKtd
{
    public string PatientIncidentNo { get; set; } = null!;

    public string SrincidentKtd { get; set; } = null!;

    public string IncidentKtdname { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
