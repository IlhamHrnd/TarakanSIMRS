using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeePosition
{
    public int EmployeePositionId { get; set; }

    public int PersonId { get; set; }

    public int PositionId { get; set; }

    public bool IsPrimaryPosition { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? AssignmentNo { get; set; }

    public string? ResignmentNo { get; set; }

    public string? SrpositionLevel { get; set; }

    public int? CoorporateGradeId { get; set; }

    public decimal? CoorporateGradeValue { get; set; }

    public string? PositionDescription { get; set; }
}
