using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PostingStatus
{
    public int PostingId { get; set; }

    public string Month { get; set; }

    public string Year { get; set; }

    public bool IsEnabled { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public DateOnly? PostingUntilDate { get; set; }

    public int? JournalSummaryId { get; set; }

    public bool? IsFiscalYear { get; set; }

    public bool? IsUncompleteAppr { get; set; }

    public int? JournalGroupId { get; set; }

    public bool? IsConsolidation { get; set; }

    public int? ConsolidationJournalId { get; set; }
}
