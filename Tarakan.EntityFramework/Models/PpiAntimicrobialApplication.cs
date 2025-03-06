using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiAntimicrobialApplication
{
    public string RegistrationNo { get; set; }

    public string SrtherapyGroup { get; set; }

    public string TherapyId { get; set; }

    public decimal? Dosage { get; set; }

    public string SrdosageUnit { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string SrantimicrobialApplicationTiming { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
