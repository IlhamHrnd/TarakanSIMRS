using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeOrganization
{
    public int EmployeeOrganizationId { get; set; }

    public int PersonId { get; set; }

    public int OrganizationId { get; set; }

    public int SubOrganizationId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ServiceUnitId { get; set; }

    public int? SubDivisonId { get; set; }

    public string SrorganizationLevelType { get; set; }
}
