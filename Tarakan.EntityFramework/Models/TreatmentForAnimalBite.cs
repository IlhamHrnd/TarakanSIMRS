using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TreatmentForAnimalBite
{
    public string RegistrationNo { get; set; } = null!;

    public string SrtreatmentForAnimalBites { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
