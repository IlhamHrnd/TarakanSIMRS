using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AbRestriction
{
    public string AbRestrictionId { get; set; }

    public string ParentId { get; set; }

    public string AbRestrictionName { get; set; }

    public string SrabRestrictionType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsNotRestricted { get; set; }
}
