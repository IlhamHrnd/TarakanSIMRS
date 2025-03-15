using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeByFee4ServiceSetting
{
    public int Id { get; set; }

    public string? ParamedicId { get; set; }

    public string? Srspecialty { get; set; }

    public string? SrtariffType { get; set; }

    public string? GuarantorId { get; set; }

    public string? SrregistrationType { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? ItemGroupId { get; set; }

    public string? ItemId { get; set; }

    public string? TariffComponentId { get; set; }

    public bool IsFeeValueInPercent { get; set; }

    public decimal? FeeValue { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? Srprocedure { get; set; }

    public bool? IsFeeValueFromPlafon { get; set; }

    public string? ClassId { get; set; }

    public bool? IsFeeValueFromTariffPrice { get; set; }

    public string? SrguarantorType { get; set; }

    public string? SrparamedicStatus { get; set; }

    public string? Formula { get; set; }

    public bool? IsUsingFormula { get; set; }

    public int? Level { get; set; }

    public string? Notes { get; set; }

    public string? SritemConditionRuleType { get; set; }

    public string? ItemConditionRuleId { get; set; }

    public string? FormulaNetto { get; set; }
}
