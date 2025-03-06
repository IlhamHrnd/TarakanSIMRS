using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeSalaryMatrix
{
    public long EmployeeSalaryMatrixId { get; set; }

    public int PersonId { get; set; }

    public int SalaryComponentId { get; set; }

    public int Qty { get; set; }

    public decimal NominalAmount { get; set; }

    public string SrcurrencyCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
