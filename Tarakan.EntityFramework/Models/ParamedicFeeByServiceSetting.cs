using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeByServiceSetting
{
    public int Id { get; set; }

    public string SrregistrationType { get; set; }

    public string ServiceUnitId { get; set; }

    public string ItemId { get; set; }

    public string ClassId { get; set; }

    public string SrparamedicFeeCaseType { get; set; }

    public string SrparamedicFeeIsTeam { get; set; }

    public string SrparamedicFeeTeamStatus { get; set; }

    public string TariffComponentId { get; set; }

    public bool IsFeeValueInPercent { get; set; }

    public decimal FeeValue { get; set; }

    public int CountMax { get; set; }

    public bool? IgnoredIfAnyReplacement { get; set; }

    public bool? IsReplacement { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public bool? IsReplacementForFeeByPercentageOfAr { get; set; }
}
