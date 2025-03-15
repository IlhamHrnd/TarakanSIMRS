using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationDrugObsPto
{
    public string RegistrationNo { get; set; } = null!;

    public int DrugObsNo { get; set; }

    public string Srpto { get; set; } = null!;

    public bool? IsYes { get; set; }

    public string? YesNotes { get; set; }

    public bool? IsDrugDuplicate { get; set; }

    public bool? IsMoreThan7Days { get; set; }

    public bool? IsAgeMoreThan65y { get; set; }

    public bool? IsSindromGeriatry { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
