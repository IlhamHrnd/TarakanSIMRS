using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PcareReferenceItem
{
    public string ReferenceId { get; set; }

    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string ResponseData { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
