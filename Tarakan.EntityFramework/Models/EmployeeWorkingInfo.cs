using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeWorkingInfo
{
    public int PersonId { get; set; }

    public DateTime JoinDate { get; set; }

    public int? SupervisorId { get; set; }

    public string SremployeeStatus { get; set; }

    public string SremployeeType { get; set; }

    public int? PositionGradeId { get; set; }

    public string SrremunerationType { get; set; }

    public string AbsenceCardNo { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsKwi { get; set; }

    public decimal? GradeYear { get; set; }

    public string SreducationLevel { get; set; }

    public DateTime? ResignDate { get; set; }

    public string SrresignReason { get; set; }

    public string EmployeeRegistrationNo { get; set; }

    public int? PreceptorId { get; set; }

    public string SremployeeShiftType { get; set; }

    public string SremployeeScheduleType { get; set; }

    public string SrprofessionType { get; set; }

    public string SrclinicalWorkArea { get; set; }

    public string SrclinicalAuthorityLevel { get; set; }

    public int? ManagerId { get; set; }
}
