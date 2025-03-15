using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WorkingHourOrganizationUnit
{
    public int WorkingHourId { get; set; }

    public int OrganizationUnitId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateUserId { get; set; }
}
