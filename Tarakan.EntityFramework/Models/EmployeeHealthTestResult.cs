using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeHealthTestResult
{
    public string RegistrationNo { get; set; } = null!;

    public DateTime ResultDate { get; set; }

    public int PersonId { get; set; }

    public string EmployeeServiceUnitId { get; set; } = null!;

    public string Examination { get; set; } = null!;

    public string Result { get; set; } = null!;

    public string SrhealthDegreeConclusion { get; set; } = null!;

    public string K3rsRecomendation { get; set; } = null!;

    public string PhysicianRecomendation { get; set; } = null!;

    public bool IsMcu { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
