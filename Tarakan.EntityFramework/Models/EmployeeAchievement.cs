using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeAchievement
{
    public int EmployeeAchievementId { get; set; }

    public int PersonId { get; set; }

    public int AwardId { get; set; }

    public DateTime AwardDate { get; set; }

    public string Achievement { get; set; }

    public decimal? FinancialValue { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
