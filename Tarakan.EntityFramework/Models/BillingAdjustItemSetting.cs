using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BillingAdjustItemSetting
{
    public int Id { get; set; }

    public string? ParamedicId { get; set; }

    public string? Srspecialty { get; set; }

    public string? SrtariffType { get; set; }

    public string? GuarantorId { get; set; }

    public string? SrregistrationType { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? ItemId { get; set; }

    public string? ClassId { get; set; }

    public string? TariffComponentId { get; set; }

    public bool IsFeeValueInPercent { get; set; }

    public decimal? FeeValue { get; set; }

    public string? ItemGroupIdsReplacement { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
