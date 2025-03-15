using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeMedicalInsurance
{
    public string MedicalInsuranceNo { get; set; } = null!;

    public int PersonId { get; set; }

    public int PersonalFamilyId { get; set; }

    public DateTime ForTreatmentDate { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string SrmedicalInsuranceType { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
