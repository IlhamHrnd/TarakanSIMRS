using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ContributoryFactorsClassificationFrameworkItem
{
    public string FactorId { get; set; }

    public string FactorItemId { get; set; }

    public string FactorItemName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
