using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeHealthTestResult
{
    public string RegistrationNo { get; set; }

    public DateTime ResultDate { get; set; }

    public int PersonId { get; set; }

    public string EmployeeServiceUnitId { get; set; }

    public string Examination { get; set; }

    public string Result { get; set; }

    public string SrhealthDegreeConclusion { get; set; }

    public string K3rsRecomendation { get; set; }

    public string PhysicianRecomendation { get; set; }

    public bool IsMcu { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
