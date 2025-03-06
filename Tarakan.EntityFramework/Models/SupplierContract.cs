using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SupplierContract
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string SupplierId { get; set; }

    public string ContractNo { get; set; }

    public DateTime ContractStart { get; set; }

    public DateTime ContractEnd { get; set; }

    public string ContractSummary { get; set; }

    public decimal ContractAmount { get; set; }

    public decimal PurchaseAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual ICollection<SupplierContractItem> SupplierContractItems { get; set; } = new List<SupplierContractItem>();
}
