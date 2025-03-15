using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalEmployeeInitial
{
    public int MedicalEmployeeInitialId { get; set; }

    public int PersonId { get; set; }

    public string Year { get; set; } = null!;

    public decimal EmployeeUsedAmount { get; set; }

    public decimal DependentUsedAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
