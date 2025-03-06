using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PcareReferenceItemMapping
{
    public string ReferenceId { get; set; }

    public string MappingWithId { get; set; }

    public string ItemId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
