using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryScale
{
    public int SalaryScaleId { get; set; }

    public string SalaryScaleCode { get; set; } = null!;

    public string SalaryScaleName { get; set; } = null!;

    public int PositionGradeId { get; set; }

    public string SremploymentType { get; set; } = null!;

    public string SrprofessionGroup { get; set; } = null!;

    public string SreducationGroup { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
