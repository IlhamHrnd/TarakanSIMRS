using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Item
{
    public string ItemId { get; set; }

    public string ItemGroupId { get; set; }

    public string SritemType { get; set; }

    public string ItemName { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; }

    public string ItemIdexternal { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrbillingGroup { get; set; }

    public string ProductAccountId { get; set; }

    public bool? IsItemProduction { get; set; }

    public string GuarantorId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public bool? IsHasTestResults { get; set; }

    public bool? IsNeedToBeSterilized { get; set; }

    public string SrbridgingType { get; set; }

    public string SrcssdItemGroup { get; set; }

    public string SrbpjsItemGroup { get; set; }

    public string SreklaimTariffGroup { get; set; }

    public string Barcode { get; set; }

    public byte[] Photo { get; set; }

    public string SritemCategory { get; set; }

    public decimal? CssdPackagingCostAmount { get; set; }

    public short? IntervalOrderWarning { get; set; }

    public string SreklaimFactorGroup { get; set; }

    public string SritemSubGroup { get; set; }

    public DateTime? ValidityPeriodFrom { get; set; }

    public DateTime? ValidityPeriodTo { get; set; }

    public bool? IsAsset { get; set; }

    public string AssetGroupId { get; set; }

    public bool? IsDelegationToNurse { get; set; }

    public virtual ItemDiagnostic ItemDiagnostic { get; set; }

    public virtual ItemKitchen ItemKitchen { get; set; }

    public virtual ItemLaboratory ItemLaboratory { get; set; }

    public virtual ItemOptic ItemOptic { get; set; }

    public virtual ItemProductMedic ItemProductMedic { get; set; }

    public virtual ItemProductNonMedic ItemProductNonMedic { get; set; }

    public virtual ItemRadiology ItemRadiology { get; set; }

    public virtual ItemService ItemService { get; set; }
}
