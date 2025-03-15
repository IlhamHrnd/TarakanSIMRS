using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeGradeMaster
{
    public int EmployeeGradeMasterId { get; set; }

    public string EmployeeGradeCode { get; set; } = null!;

    public string EmployeeGradeName { get; set; } = null!;

    public string? Description { get; set; }

    public int Rangking { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
