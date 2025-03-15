using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeByNumberOfPatient
{
    public DateTime RegistrationDate { get; set; }

    public string ParamedicId { get; set; } = null!;

    public short NumberOfPatient { get; set; }

    public decimal FeeAmount { get; set; }

    public string? VerificationNo { get; set; }

    public DateTime? LastCalculatedDateTime { get; set; }

    public string? LastCalculatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
