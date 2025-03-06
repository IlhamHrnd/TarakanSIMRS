using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionEmploymentCompany
{
    public int PositionEmploymentCompanyId { get; set; }

    public int PositionId { get; set; }

    public string Srrequirement { get; set; }

    public int? YearOfService { get; set; }

    public int? PositionGradeId { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
