using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CompanyFieldOfWorkProfile
{
    public int CompanyFieldOfWorkProfileId { get; set; }

    public int CompanyLaborProfileId { get; set; }

    public string CompanyFieldOfWorkProfileCode { get; set; }

    public string CompanyFieldOfWorkProfileName { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
