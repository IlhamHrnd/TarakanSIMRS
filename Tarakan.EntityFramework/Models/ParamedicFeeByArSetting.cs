using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeByArSetting
{
    public int Id { get; set; }

    public string SrregistrationType { get; set; } = null!;

    public bool IsMergeToIpr { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string SrparamedicFeeCaseType { get; set; } = null!;

    public string SrparamedicFeeIsTeam { get; set; } = null!;

    public int LosStart { get; set; }

    public int LosEnd { get; set; }

    public string SrparamedicFeeTeamStatus { get; set; } = null!;

    public bool IsFeeValueInPercent { get; set; }

    public decimal FeeValue { get; set; }

    public string CreatedByUserId { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? SmfId { get; set; }
}
