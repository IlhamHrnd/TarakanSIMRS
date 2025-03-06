using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalOrganization
{
    public int PersonalOrganizationId { get; set; }

    public int PersonId { get; set; }

    public string OrganizationName { get; set; }

    public string Location { get; set; }

    public string SrorganizationType { get; set; }

    public string SrorganizationRole { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
