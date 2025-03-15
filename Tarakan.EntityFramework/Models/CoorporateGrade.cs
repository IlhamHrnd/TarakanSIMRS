using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CoorporateGrade
{
    public int CoorporateGradeId { get; set; }

    public short CoorporateGradeLevel { get; set; }

    public decimal CoorporateGradeMin { get; set; }

    public decimal CoorporateGradeMax { get; set; }

    public decimal CoorporateGradeInterval { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? CoorporateGradeCoefficient { get; set; }
}
