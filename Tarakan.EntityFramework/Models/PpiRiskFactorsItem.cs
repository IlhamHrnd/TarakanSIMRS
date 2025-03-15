using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiRiskFactorsItem
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public DateTime DateOfInfection { get; set; }

    public string SrsignsOfInfection { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
