using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwEmployeeTable
{
    public int PersonId { get; set; }

    public string EmployeeNumber { get; set; }

    public string EmployeeName { get; set; }

    public string EmployeeRegistrationNo { get; set; }

    public int ManagerId { get; set; }

    public int SupervisorId { get; set; }

    public int PreceptorId { get; set; }

    public string SremployeeType { get; set; }

    public string SrremunerationType { get; set; }

    public string SremployeeShiftType { get; set; }

    public string SremployeeScheduleType { get; set; }

    public string SrprofessionType { get; set; }

    public string SrprofessionGroup { get; set; }

    public string SrclinicalWorkArea { get; set; }

    public string SrclinicalAuthorityLevel { get; set; }

    public int OrganizationUnitId { get; set; }

    public int SubOrganizationUnitId { get; set; }

    public string SrpaymentFrequency { get; set; }

    public string SrtaxStatus { get; set; }

    public string SremployeeStatus { get; set; }

    public int PositionId { get; set; }

    public string Srreligion { get; set; }

    public string SrbloodType { get; set; }

    public string BankId { get; set; }

    public string BankNo { get; set; }

    public string BankAccountName { get; set; }

    public string SrincentiveServiceUnitGroup { get; set; }

    public string SrincentivePositionGroup { get; set; }

    public string SrincentivePosition { get; set; }

    public decimal IncentivePositionPoints { get; set; }

    public string SremploymentType { get; set; }

    public string SremploymentCategory { get; set; }

    public int PositionGradeId { get; set; }

    public int PositionLevelId { get; set; }

    public string SrmaritalStatus { get; set; }

    public DateTime JoinDate { get; set; }

    public DateTime BirthDate { get; set; }

    public string PlaceBirth { get; set; }

    public decimal? ServiceYear { get; set; }

    public string ServiceYearText { get; set; }

    public decimal? ServiceYearPermanent { get; set; }

    public string ServiceYearPermanentText { get; set; }

    public string EmployeeLevel { get; set; }

    public int SalaryTableNumber { get; set; }

    public int EmployeeGradeId { get; set; }

    public int NoOfDependent { get; set; }

    public int IsKwi { get; set; }

    public string SreducationLevel { get; set; }

    public string SrfieldLabor { get; set; }

    public string SreducationGroup { get; set; }

    public int GradeYear { get; set; }

    public int SalaryScaleId { get; set; }

    public string CoverageClass { get; set; }

    public string CoverageClassBpjs { get; set; }

    public string SrgenderType { get; set; }

    public string PatientId { get; set; }

    public DateTime? ResignDate { get; set; }

    public DateTime? ResignDateReal { get; set; }

    public string SrresignReason { get; set; }

    public int IsBpjs { get; set; }

    public int? BpjsuncoveredNo { get; set; }

    public int BpjscoveredNo { get; set; }

    public decimal? ServiceMonthThr { get; set; }

    public int? ServiceMonthPph { get; set; }

    public int IsJp { get; set; }

    public string AbsenceCardNo { get; set; }

    public int SubDivisonId { get; set; }

    public string ServiceUnitId { get; set; }

    public string EmployeeTypePayroll { get; set; }

    public bool? IsSalaryManaged { get; set; }

    public DateTime? TglDiangkat { get; set; }

    public string IjazahPengangkatan { get; set; }

    public int IsNpwp { get; set; }

    public string Npwp { get; set; }

    public DateTime PositionValidFromDate { get; set; }

    public string ProfessionType { get; set; }

    public string BpjsKesNo { get; set; }

    public string BpjsTkNo { get; set; }

    public int SupervisedCount { get; set; }
}
