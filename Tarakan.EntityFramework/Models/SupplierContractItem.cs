using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SupplierContractItem
{
    public string TransactionNo { get; set; }

    public string ItemId { get; set; }

    public string SrpurchaseUnit { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PurchaseDiscount1 { get; set; }

    public decimal PurchaseDiscount2 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual SupplierContract TransactionNoNavigation { get; set; }
}
