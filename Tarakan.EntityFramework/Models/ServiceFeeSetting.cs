using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceFeeSetting
{
    public int Id { get; set; }

    public int? Level { get; set; }

    public string ParamedicId { get; set; }

    public string Srspecialty { get; set; }

    public string SrtariffType { get; set; }

    public string GuarantorId { get; set; }

    public string SrregistrationType { get; set; }

    public string ServiceUnitId { get; set; }

    public string ItemGroupId { get; set; }

    public string ItemId { get; set; }

    public string TariffComponentId { get; set; }

    public string Srprocedure { get; set; }

    public string ClassId { get; set; }

    public string SrguarantorType { get; set; }

    public string SrparamedicStatus { get; set; }

    public string Notes { get; set; }

    public string SritemConditionRuleType { get; set; }

    public string ItemConditionRuleId { get; set; }

    public string FormulaDirektur { get; set; }

    public string FormulaStruktural { get; set; }

    public string FormulaMedis { get; set; }

    public string FormulaUnit { get; set; }

    public string FormulaPemerataan { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
