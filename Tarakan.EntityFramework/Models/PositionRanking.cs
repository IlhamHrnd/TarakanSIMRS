using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionRanking
{
    public int PositionRankingId { get; set; }

    public int PositionId { get; set; }

    public string RankingName { get; set; }

    public string Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
