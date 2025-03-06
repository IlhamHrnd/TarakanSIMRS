using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QueLocationItem
{
    public int LocationId { get; set; }

    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public string UpdateByUserId { get; set; }

    public bool? VisitingType { get; set; }
}
