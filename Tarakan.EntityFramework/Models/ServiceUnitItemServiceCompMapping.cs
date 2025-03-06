using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitItemServiceCompMapping
{
    public string ServiceUnitId { get; set; }

    public string ItemId { get; set; }

    public string TariffComponentId { get; set; }

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrregistrationType { get; set; }

    public string SrguarantorIncomeGroup { get; set; }
}
