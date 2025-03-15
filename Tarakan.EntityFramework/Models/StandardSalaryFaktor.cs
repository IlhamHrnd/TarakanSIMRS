using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class StandardSalaryFaktor
{
    public int StandardSalaryFaktorId { get; set; }

    public int StandardSalaryId { get; set; }

    public int GradeServiceYear { get; set; }

    public decimal AmountSalary { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
