using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VisitType
{
    public string VisitTypeId { get; set; }

    public string VisitTypeName { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
