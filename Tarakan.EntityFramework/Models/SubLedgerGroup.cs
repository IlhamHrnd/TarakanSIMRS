using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SubLedgerGroup
{
    public int SubLedgerGroupId { get; set; }

    public string GroupCode { get; set; }

    public string GroupName { get; set; }

    public string Description { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? TempId { get; set; }

    public virtual ICollection<SubLedger> SubLedgers { get; set; } = new List<SubLedger>();
}
