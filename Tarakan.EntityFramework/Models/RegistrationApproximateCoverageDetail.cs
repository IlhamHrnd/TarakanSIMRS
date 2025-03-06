using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationApproximateCoverageDetail
{
    public string RegistrationNo { get; set; }

    public string ClassId { get; set; }

    public decimal CoverageAmount { get; set; }

    public decimal CalculatedAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
