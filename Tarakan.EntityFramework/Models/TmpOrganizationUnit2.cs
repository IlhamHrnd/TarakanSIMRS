using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpOrganizationUnit2
{
    public double? OrganizationUnitId { get; set; }

    public string OrganizationUnitCode { get; set; }

    public string OrganizationName { get; set; }

    public double? OrganizationLevel { get; set; }

    public double? ParentOrganizationUnit { get; set; }
}
