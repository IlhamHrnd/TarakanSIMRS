using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanAspectsOfBehaviorGrade
{
    public int GradeId { get; set; }

    public int GradeValue { get; set; }

    public string Explanation { get; set; } = null!;

    public string Categorization { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
