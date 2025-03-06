using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationPatientRiskStatusHistory
{
    public string RegistrationNo { get; set; }

    public string FromSrpatientRiskStatus { get; set; }

    public string ToSrpatientRiskStatus { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
