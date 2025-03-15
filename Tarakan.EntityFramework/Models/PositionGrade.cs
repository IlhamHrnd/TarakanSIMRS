using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionGrade
{
    public int PositionGradeId { get; set; }

    public string? PositionGradeCode { get; set; }

    public string PositionGradeName { get; set; } = null!;

    public string Interval { get; set; } = null!;

    public short Ranking { get; set; }

    public string? RankName { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? SremploymentType { get; set; }

    public decimal? LowerLimit { get; set; }

    public decimal? UpperLimit { get; set; }
}
