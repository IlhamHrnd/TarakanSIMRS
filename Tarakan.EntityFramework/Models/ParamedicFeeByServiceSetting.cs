using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeByServiceSetting
{
    public int Id { get; set; }

    public string SrregistrationType { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string SrparamedicFeeCaseType { get; set; } = null!;

    public string SrparamedicFeeIsTeam { get; set; } = null!;

    public string SrparamedicFeeTeamStatus { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public bool IsFeeValueInPercent { get; set; }

    public decimal FeeValue { get; set; }

    public int CountMax { get; set; }

    public bool? IgnoredIfAnyReplacement { get; set; }

    public bool? IsReplacement { get; set; }

    public string CreatedByUserId { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public bool? IsReplacementForFeeByPercentageOfAr { get; set; }
}
