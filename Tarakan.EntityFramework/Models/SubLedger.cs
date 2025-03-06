using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SubLedger
{
    public int SubLedgerId { get; set; }

    public int GroupId { get; set; }

    public string SubLedgerName { get; set; }

    public string Description { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? TempId { get; set; }

    public int? HoSubLedgerId { get; set; }

    public string HoDescription { get; set; }

    public bool? IsDirectCost { get; set; }

    public virtual SubLedgerGroup Group { get; set; }

    public virtual ICollection<SubLedgerBalance> SubLedgerBalances { get; set; } = new List<SubLedgerBalance>();
}
