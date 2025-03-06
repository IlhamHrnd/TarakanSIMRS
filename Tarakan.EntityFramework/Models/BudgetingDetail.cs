using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BudgetingDetail
{
    public string BudgetingNo { get; set; }

    public int Revision { get; set; }

    public int ChartOfAccountId { get; set; }

    public decimal Limit01 { get; set; }

    public decimal Limit02 { get; set; }

    public decimal Limit03 { get; set; }

    public decimal Limit04 { get; set; }

    public decimal Limit05 { get; set; }

    public decimal Limit06 { get; set; }

    public decimal Limit07 { get; set; }

    public decimal Limit08 { get; set; }

    public decimal Limit09 { get; set; }

    public decimal Limit10 { get; set; }

    public decimal Limit11 { get; set; }

    public decimal Limit12 { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
