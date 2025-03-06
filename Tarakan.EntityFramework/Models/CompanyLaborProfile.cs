using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CompanyLaborProfile
{
    public int CompanyLaborProfileId { get; set; }

    public string CompanyLaborProfileCode { get; set; }

    public string CompanyLaborProfileName { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
