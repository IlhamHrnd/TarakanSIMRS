using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiAntimicrobialApplication
{
    public string RegistrationNo { get; set; } = null!;

    public string SrtherapyGroup { get; set; } = null!;

    public string TherapyId { get; set; } = null!;

    public decimal? Dosage { get; set; }

    public string? SrdosageUnit { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? SrantimicrobialApplicationTiming { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
