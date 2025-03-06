using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class IncomeJournalStatus
{
    public int Id { get; set; }

    public string Month { get; set; }

    public string Year { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public int? JournalId { get; set; }
}
