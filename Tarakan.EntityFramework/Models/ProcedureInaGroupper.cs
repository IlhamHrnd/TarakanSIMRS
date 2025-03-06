using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ProcedureInaGroupper
{
    public string ProcedureId { get; set; }

    public string ProcedureName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
