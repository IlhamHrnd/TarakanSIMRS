using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Award
{
    public int AwardId { get; set; }

    public string AwardCode { get; set; } = null!;

    public string AwardName { get; set; } = null!;

    public string SrawardCriteria { get; set; } = null!;

    public string SrawardType { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string AwardPrize { get; set; } = null!;

    public string Note { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
