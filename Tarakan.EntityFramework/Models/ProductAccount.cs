using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ProductAccount
{
    public string ProductAccountId { get; set; }

    public string ProductAccountName { get; set; }

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

    public int? ChartOfAccountIdAcrual { get; set; }

    public int? SubledgerIdAcrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? ChartOfAccountIdIncomeIp { get; set; }

    public int? SubledgerIdIncomeIp { get; set; }

    public int? ChartOfAccountIdInventoryIp { get; set; }

    public int? SubledgerIdInventoryIp { get; set; }

    public int? ChartOfAccountIdCogsip { get; set; }

    public int? SubledgerIdCogsip { get; set; }

    public int? ChartOfAccountIdSalesReturnIp { get; set; }

    public int? SubledgerIdSalesReturnIp { get; set; }

    public int? ChartOfAccountIdPurchaseReturnIp { get; set; }

    public int? SubledgerIdPurchaseReturnIp { get; set; }

    public int? ChartOfAccountIdAcrualIp { get; set; }

    public int? SubledgerIdAcrualIp { get; set; }

    public int? ChartOfAccountIdDiscountIp { get; set; }

    public int? SubledgerIdDiscountIp { get; set; }

    public int? ChartOfAccountIdCostIp { get; set; }

    public int? SubledgerIdCostIp { get; set; }

    public int? ChartOfAccountIdIncomeIgd { get; set; }

    public int? SubledgerIdIncomeIgd { get; set; }

    public int? ChartOfAccountIdInventoryIgd { get; set; }

    public int? SubledgerIdInventoryIgd { get; set; }

    public int? ChartOfAccountIdCogsigd { get; set; }

    public int? SubledgerIdCogsigd { get; set; }

    public int? ChartOfAccountIdSalesReturnIgd { get; set; }

    public int? SubledgerIdSalesReturnIgd { get; set; }

    public int? ChartOfAccountIdPurchaseReturnIgd { get; set; }

    public int? SubledgerIdPurchaseReturnIgd { get; set; }

    public int? ChartOfAccountIdAcrualIgd { get; set; }

    public int? SubledgerIdAcrualIgd { get; set; }

    public int? ChartOfAccountIdDiscountIgd { get; set; }

    public int? SubledgerIdDiscountIgd { get; set; }

    public int? ChartOfAccountIdCostIgd { get; set; }

    public int? SubledgerIdCostIgd { get; set; }

    public string SritemType { get; set; }

    public int? ChartOfAccountIdCogsoptemp { get; set; }

    public int? SubledgerIdCogsoptemp { get; set; }

    public int? ChartOfAccountIdCogsiptemp { get; set; }

    public int? SubledgerIdCogsiptemp { get; set; }

    public int? ChartOfAccountIdCogsigdtemp { get; set; }

    public int? SubledgerIdCogsigdtemp { get; set; }
}
