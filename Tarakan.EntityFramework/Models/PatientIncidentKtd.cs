using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentKtd
{
    public string PatientIncidentNo { get; set; }

    public string SrincidentKtd { get; set; }

    public string IncidentKtdname { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
