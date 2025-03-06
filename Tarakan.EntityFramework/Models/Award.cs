using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Award
{
    public int AwardId { get; set; }

    public string AwardCode { get; set; }

    public string AwardName { get; set; }

    public string SrawardCriteria { get; set; }

    public string SrawardType { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string AwardPrize { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
