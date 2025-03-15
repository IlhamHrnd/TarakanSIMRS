using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiRiskFactor
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SrriskFactorsType { get; set; } = null!;

    public string RiskFactorsId { get; set; } = null!;

    public string? SrriskFactorsLocation { get; set; }

    public DateTime? DateOfInitialInstallation { get; set; }

    public DateTime? DateOfFinalInstallation { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
