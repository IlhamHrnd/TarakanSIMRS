using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationDrugObsDrp
{
    public string RegistrationNo { get; set; } = null!;

    public int DrugObsNo { get; set; }

    public string Srdrps { get; set; } = null!;

    public bool? IsYes { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
