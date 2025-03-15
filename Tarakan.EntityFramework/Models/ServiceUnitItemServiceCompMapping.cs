using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitItemServiceCompMapping
{
    public string ServiceUnitId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string SrregistrationType { get; set; } = null!;

    public string SrguarantorIncomeGroup { get; set; } = null!;
}
