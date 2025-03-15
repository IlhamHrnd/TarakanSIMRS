using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CompanyEducationProfile
{
    public int CompanyEducationProfileId { get; set; }

    public int CompanyLaborProfileId { get; set; }

    public string CompanyEducationProfileCode { get; set; } = null!;

    public string CompanyEducationProfileName { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
