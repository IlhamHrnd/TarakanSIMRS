using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class OperationCostEstimationItem
{
    public string DiagnoseId { get; set; }

    public string ProcedureId { get; set; }

    public string SrprocedureCategory { get; set; }

    public string ClassId { get; set; }

    public string RegistrationNo { get; set; }

    public string ItemGroupId { get; set; }

    public string ItemGroupName { get; set; }

    public string SrbillingGroup { get; set; }

    public decimal? CostAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
