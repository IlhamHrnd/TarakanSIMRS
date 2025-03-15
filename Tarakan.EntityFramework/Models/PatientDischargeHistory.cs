using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientDischargeHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string BedId { get; set; } = null!;

    public DateTime DischargeDate { get; set; }

    public string DischargeTime { get; set; } = null!;

    public string DischargeOperatorId { get; set; } = null!;

    public bool IsCancel { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
