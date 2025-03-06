using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeePositionGrade
{
    public long EmployeePositionGradeId { get; set; }

    public int? PersonId { get; set; }

    public string SreducationLevel { get; set; }

    public DateTime? ValidFrom { get; set; }

    public int? PositionGradeId { get; set; }

    public int? GradeYear { get; set; }

    public string SrdecreeType { get; set; }

    public string DecreeNo { get; set; }

    public string PositionName { get; set; }

    public DateTime? NextProposalDate { get; set; }

    public int? NextPositionGradeId { get; set; }

    public int? NextGradeYear { get; set; }

    public string SrdecreeTypeNext { get; set; }

    public string NextPositionName { get; set; }

    public string Srdp3 { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? SalaryScaleId { get; set; }

    public int? NextSalaryScaleId { get; set; }
}
