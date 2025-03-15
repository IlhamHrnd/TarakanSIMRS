using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationDrugOb
{
    public string RegistrationNo { get; set; } = null!;

    public int DrugObsNo { get; set; }

    public DateTime DrugObsDateTime { get; set; }

    public string? ServiceUnitId { get; set; }

    public bool? IsNeedPto { get; set; }

    public string? DrugInteractionRisk { get; set; }

    public string? Recommendation { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
