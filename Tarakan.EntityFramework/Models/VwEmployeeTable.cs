using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwEmployeeTable
{
    public int PersonId { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? EmployeeName { get; set; }

    public string EmployeeRegistrationNo { get; set; } = null!;

    public int ManagerId { get; set; }

    public int SupervisorId { get; set; }

    public int PreceptorId { get; set; }

    public string SremployeeType { get; set; } = null!;

    public string SrremunerationType { get; set; } = null!;

    public string SremployeeShiftType { get; set; } = null!;

    public string SremployeeScheduleType { get; set; } = null!;

    public string SrprofessionType { get; set; } = null!;

    public string SrprofessionGroup { get; set; } = null!;

    public string SrclinicalWorkArea { get; set; } = null!;

    public string SrclinicalAuthorityLevel { get; set; } = null!;

    public int OrganizationUnitId { get; set; }

    public int SubOrganizationUnitId { get; set; }

    public string SrpaymentFrequency { get; set; } = null!;

    public string SrtaxStatus { get; set; } = null!;

    public string SremployeeStatus { get; set; } = null!;

    public int PositionId { get; set; }

    public string Srreligion { get; set; } = null!;

    public string SrbloodType { get; set; } = null!;

    public string BankId { get; set; } = null!;

    public string BankNo { get; set; } = null!;

    public string BankAccountName { get; set; } = null!;

    public string SrincentiveServiceUnitGroup { get; set; } = null!;

    public string SrincentivePositionGroup { get; set; } = null!;

    public string SrincentivePosition { get; set; } = null!;

    public decimal IncentivePositionPoints { get; set; }

    public string SremploymentType { get; set; } = null!;

    public string SremploymentCategory { get; set; } = null!;

    public int PositionGradeId { get; set; }

    public int PositionLevelId { get; set; }

    public string SrmaritalStatus { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public DateTime BirthDate { get; set; }

    public string? PlaceBirth { get; set; }

    public decimal? ServiceYear { get; set; }

    public string? ServiceYearText { get; set; }

    public decimal? ServiceYearPermanent { get; set; }

    public string? ServiceYearPermanentText { get; set; }

    public string EmployeeLevel { get; set; } = null!;

    public int SalaryTableNumber { get; set; }

    public int EmployeeGradeId { get; set; }

    public int NoOfDependent { get; set; }

    public int IsKwi { get; set; }

    public string SreducationLevel { get; set; } = null!;

    public string SrfieldLabor { get; set; } = null!;

    public string SreducationGroup { get; set; } = null!;

    public int GradeYear { get; set; }

    public int SalaryScaleId { get; set; }

    public string CoverageClass { get; set; } = null!;

    public string CoverageClassBpjs { get; set; } = null!;

    public string SrgenderType { get; set; } = null!;

    public string? PatientId { get; set; }

    public DateTime? ResignDate { get; set; }

    public DateTime? ResignDateReal { get; set; }

    public string? SrresignReason { get; set; }

    public int IsBpjs { get; set; }

    public int? BpjsuncoveredNo { get; set; }

    public int BpjscoveredNo { get; set; }

    public decimal? ServiceMonthThr { get; set; }

    public int? ServiceMonthPph { get; set; }

    public int IsJp { get; set; }

    public string? AbsenceCardNo { get; set; }

    public int SubDivisonId { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string EmployeeTypePayroll { get; set; } = null!;

    public bool? IsSalaryManaged { get; set; }

    public DateTime? TglDiangkat { get; set; }

    public string? IjazahPengangkatan { get; set; }

    public int IsNpwp { get; set; }

    public string Npwp { get; set; } = null!;

    public DateTime PositionValidFromDate { get; set; }

    public string? ProfessionType { get; set; }

    public string? BpjsKesNo { get; set; }

    public string? BpjsTkNo { get; set; }

    public int SupervisedCount { get; set; }
}
