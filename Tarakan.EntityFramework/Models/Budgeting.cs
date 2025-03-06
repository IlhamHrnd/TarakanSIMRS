using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Budgeting
{
    public string BudgetingNo { get; set; }

    public string ServiceUnitId { get; set; }

    public int Periode { get; set; }

    public int Revision { get; set; }

    public decimal SumLimit { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public bool IsApprove { get; set; }

    public string ApprovedByUserId { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public bool IsVoid { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidNotes { get; set; }

    public string SrbudgetingVerifyStatus { get; set; }

    public string VerifiedByUserId { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string Notes { get; set; }

    public string CorrectionNotes { get; set; }

    public bool? IsByItem { get; set; }

    public string SrbudgetingGroup { get; set; }
}
