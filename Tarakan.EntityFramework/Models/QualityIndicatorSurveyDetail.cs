using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QualityIndicatorSurveyDetail
{
    public int DetailId { get; set; }

    public int SurveyId { get; set; }

    public string ItemId { get; set; } = null!;

    public int Numerator { get; set; }

    public string? InputQueryNumer { get; set; }

    public int Denumerator { get; set; }

    public string? InputQueryDenum { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
