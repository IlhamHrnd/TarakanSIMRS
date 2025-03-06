using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeMiscellaneousBenefit
{
    public int EmployeeMiscellaneousBenefitId { get; set; }

    public int PersonId { get; set; }

    public string SrmiscellaneousBenefit { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
