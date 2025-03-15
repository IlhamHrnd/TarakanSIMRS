using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Procedure
{
    public string ProcedureId { get; set; } = null!;

    public string ProcedureName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
