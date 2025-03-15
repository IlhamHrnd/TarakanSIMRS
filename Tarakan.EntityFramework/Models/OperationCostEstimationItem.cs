using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class OperationCostEstimationItem
{
    public string DiagnoseId { get; set; } = null!;

    public string ProcedureId { get; set; } = null!;

    public string SrprocedureCategory { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string ItemGroupId { get; set; } = null!;

    public string? ItemGroupName { get; set; }

    public string SrbillingGroup { get; set; } = null!;

    public decimal? CostAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
