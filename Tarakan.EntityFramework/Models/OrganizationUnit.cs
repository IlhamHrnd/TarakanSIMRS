using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class OrganizationUnit
{
    public int OrganizationUnitId { get; set; }

    public string OrganizationUnitCode { get; set; } = null!;

    public string OrganizationUnitName { get; set; } = null!;

    public int? ParentOrganizationUnitId { get; set; }

    public string SrorganizationLevel { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public int? PersonId { get; set; }

    public int? SubLedgerId { get; set; }
}
