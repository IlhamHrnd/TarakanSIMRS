using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeRemunDetail
{
    public int RemunDetailId { get; set; }

    public int RemunId { get; set; }

    public int PersonId { get; set; }

    public int? PositionId { get; set; }

    public string SremployeeStatus { get; set; } = null!;

    public int CoorporateGradeLevel { get; set; }

    public int CoorporateGradeValue { get; set; }

    public decimal CoorporateGradeCoefficient { get; set; }

    public decimal PositionFeeValue { get; set; }

    public decimal InsentifFeeGrossValue { get; set; }

    public decimal RenkinIndex { get; set; }

    public decimal InsentifFeeValue { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
