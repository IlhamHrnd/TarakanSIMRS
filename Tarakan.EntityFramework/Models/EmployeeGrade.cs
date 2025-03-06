using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeGrade
{
    public int EmployeeGradeId { get; set; }

    public int PersonId { get; set; }

    public int EmployeeGradeMasterId { get; set; }

    public int SalaryTableNumber { get; set; }

    public bool IsActive { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
