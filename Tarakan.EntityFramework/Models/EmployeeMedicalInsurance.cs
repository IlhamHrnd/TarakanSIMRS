using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeMedicalInsurance
{
    public string MedicalInsuranceNo { get; set; }

    public int PersonId { get; set; }

    public int PersonalFamilyId { get; set; }

    public DateTime ForTreatmentDate { get; set; }

    public string ServiceUnitId { get; set; }

    public string SrmedicalInsuranceType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
