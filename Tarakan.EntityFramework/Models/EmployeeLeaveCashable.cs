using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeLeaveCashable
{
    public int EmployeeLeaveCashableId { get; set; }

    public int PayrollPeriodId { get; set; }

    public int PersonId { get; set; }

    public int SalaryComponentId { get; set; }

    public int TotalDay { get; set; }

    public string LetterNumber { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
