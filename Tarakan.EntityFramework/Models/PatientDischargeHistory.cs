using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientDischargeHistory
{
    public string RegistrationNo { get; set; }

    public string BedId { get; set; }

    public DateTime DischargeDate { get; set; }

    public string DischargeTime { get; set; }

    public string DischargeOperatorId { get; set; }

    public bool IsCancel { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
