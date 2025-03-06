using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryScale
{
    public int SalaryScaleId { get; set; }

    public string SalaryScaleCode { get; set; }

    public string SalaryScaleName { get; set; }

    public int PositionGradeId { get; set; }

    public string SremploymentType { get; set; }

    public string SrprofessionGroup { get; set; }

    public string SreducationGroup { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
