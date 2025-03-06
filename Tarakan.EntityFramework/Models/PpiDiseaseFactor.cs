using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiDiseaseFactor
{
    public string RegistrationNo { get; set; }

    public string SrdiseaseFactorsHbsAg { get; set; }

    public string SrdiseaseFactorsAntiHcv { get; set; }

    public string SrdiseaseFactorsAntiHiv { get; set; }

    public string OtherDiseaseFactors { get; set; }

    public string Leukocyte { get; set; }

    public string Led { get; set; }

    public string Gds { get; set; }

    public string RadiologyResult { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
