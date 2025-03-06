using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class StandardSalary
{
    public int StandardSalaryId { get; set; }

    public int PositionGradeId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
