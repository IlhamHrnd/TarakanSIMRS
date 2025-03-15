using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalOrganization
{
    public int PersonalOrganizationId { get; set; }

    public int PersonId { get; set; }

    public string OrganizationName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string SrorganizationType { get; set; } = null!;

    public string SrorganizationRole { get; set; } = null!;

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
