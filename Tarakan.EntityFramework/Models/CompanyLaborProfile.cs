using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CompanyLaborProfile
{
    public int CompanyLaborProfileId { get; set; }

    public string CompanyLaborProfileCode { get; set; } = null!;

    public string CompanyLaborProfileName { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
