using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Location
{
    public string LocationId { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string? ParentId { get; set; }

    public string ItemGroupId { get; set; } = null!;

    public string? PermitId { get; set; }

    public bool IsHeader { get; set; }

    public bool IsHoldForTransaction { get; set; }

    public bool IsActive { get; set; }

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdInventory { get; set; }

    public int? SubledgerIdInventory { get; set; }

    public int? ChartOfAccountIdCogs { get; set; }

    public int? SubledgerIdCogs { get; set; }

    public int? ChartOfAccountIdSalesReturn { get; set; }

    public int? SubledgerIdSalesReturn { get; set; }

    public int? ChartOfAccountIdPurchaseReturn { get; set; }

    public int? SubledgerIdPurchaseReturn { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public int? ChartOfAccountIdAcrual { get; set; }

    public int? SubledgerIdAcrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public string? SrtypeOfInventory { get; set; }

    public bool? IsAllowedToStockGoods { get; set; }

    public bool? IsConsignment { get; set; }

    public bool? IsValidateMaxValueOnDistReqForIpm { get; set; }

    public bool? IsValidateMaxValueOnDistReqForIpnm { get; set; }

    public bool? IsValidateMaxValueOnDistReqForIk { get; set; }

    public DateTime? LastHoldForTransactionDateTime { get; set; }

    public string? LastHoldForTransactionByUserId { get; set; }

    public string? SrstockGroup { get; set; }

    public bool? IsAutoUpdateStockMinMax { get; set; }

    public bool? IsValidateMaxValueOnPurcReqForIpm { get; set; }

    public bool? IsValidateMaxValueOnPurcReqForIpnm { get; set; }

    public bool? IsValidateMaxValueOnPurcReqForIk { get; set; }

    public int? IsNotificationStockShow { get; set; }

    public int? IsNotificationType { get; set; }
}
