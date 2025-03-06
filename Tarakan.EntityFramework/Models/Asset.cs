using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Asset
{
    public string AssetId { get; set; }

    public string AssetGroupId { get; set; }

    public string AssetLocationId { get; set; }

    public string DepartmentId { get; set; }

    public string ServiceUnitId { get; set; }

    public string AssetName { get; set; }

    public string AssetBookId { get; set; }

    public string SrassetType { get; set; }

    public string Srmanufacturer { get; set; }

    public string BrandName { get; set; }

    public string SerialNumber { get; set; }

    public string DepreciationMethodId { get; set; }

    public string ItemUnit { get; set; }

    public string PurchaseOrderNumber { get; set; }

    public DateTime PurchasedDate { get; set; }

    public DateTime StartDepreciationDate { get; set; }

    public DateTime StartUsingDate { get; set; }

    public decimal PurchasedPrice { get; set; }

    public short? UsageTimeEstimation { get; set; }

    public short? AgeOfDepreciation { get; set; }

    public decimal SalesPrice { get; set; }

    public decimal CurrentValue { get; set; }

    public decimal CurrentCondition { get; set; }

    public byte CurrentUsageTimeEstimation { get; set; }

    public decimal ResidualValue { get; set; }

    public string InsuranceId { get; set; }

    public string InsurancePolicyNo { get; set; }

    public decimal InsuranceAmount { get; set; }

    public DateTime GuaranteeExpiredDate { get; set; }

    public DateTime LastInventoriedDate { get; set; }

    public string LastInventoriedBy { get; set; }

    public DateTime? LastMaintenanceDate { get; set; }

    public DateTime? NextMaintenanceDate { get; set; }

    public byte MaintenanceInterval { get; set; }

    public string MaintenanceIntervalIn { get; set; }

    public string MaintenanceServiceUnitId { get; set; }

    public DateTime IssuedDate { get; set; }

    public string IssuedBy { get; set; }

    public string SrissuedReason { get; set; }

    public string IntervalUnit { get; set; }

    public string ReferenceNo { get; set; }

    public bool IsAudiometer { get; set; }

    public bool IsSpirometer { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; }

    public string SrassetsStatus { get; set; }

    public string SrassetsCondition { get; set; }

    public string SrassetsCriticality { get; set; }

    public string NotesToTechnician { get; set; }

    public string SupplierId { get; set; }

    public string SrassetsWarrantyContract { get; set; }

    public string WarrantyContractNotes { get; set; }

    public DateTime? DateDisposed { get; set; }

    public string ItemId { get; set; }

    public bool? IsContinuousMaintenanceSchedule { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string AssetSubGroupId { get; set; }

    public bool? IsFixedAsset { get; set; }

    public decimal? ValueDisposed { get; set; }

    public string SrassetUsageTimeEstimation { get; set; }
}
