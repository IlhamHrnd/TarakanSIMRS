using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeWageStructureAndScalePosition
{
    public int WageStructureAndScalePositionId { get; set; }

    public int PersonId { get; set; }

    public DateTime ValidFrom { get; set; }

    public string SremployeeWorkGroup { get; set; }

    public string SremployeeWorkSubGroup { get; set; }

    public string SremployeeJobPosition { get; set; }

    public decimal BasePoint { get; set; }

    public decimal Points { get; set; }

    public int PositionGradeId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
