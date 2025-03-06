using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetDepreciationPost
{
    public int AssetDepreciationPostId { get; set; }

    public string AssetId { get; set; }

    public int PeriodNo { get; set; }

    public string Year { get; set; }

    public string Month { get; set; }

    public DateTime DepreciationDate { get; set; }

    public decimal CurrentAmount { get; set; }

    public decimal DepreciationAmount { get; set; }

    public decimal AccumulationAmount { get; set; }

    public bool IsPosted { get; set; }

    public int? PostingId { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? JournalId { get; set; }

    public string JournalNumber { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
