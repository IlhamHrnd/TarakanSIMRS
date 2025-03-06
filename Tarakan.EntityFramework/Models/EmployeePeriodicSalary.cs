using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeePeriodicSalary
{
    public int EmployeePeriodicSalaryId { get; set; }

    public int PayrollPeriodId { get; set; }

    public int PersonId { get; set; }

    public int SalaryComponentId { get; set; }

    public string SrprocessType { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? FromBasicSalaryAmount { get; set; }

    public int? FromPositionGradeId { get; set; }

    public int? ToPositionGradeId { get; set; }

    public int? FromGradeYear { get; set; }

    public int? ToGradeYear { get; set; }

    public decimal? OvertimeAmount { get; set; }

    public DateTime? TransactionDate { get; set; }
}
