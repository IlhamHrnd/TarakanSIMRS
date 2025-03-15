using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationPatientRiskStatusHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string FromSrpatientRiskStatus { get; set; } = null!;

    public string ToSrpatientRiskStatus { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
