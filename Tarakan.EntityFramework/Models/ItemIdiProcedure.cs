using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemIdiProcedure
{
    public string IdiCode { get; set; } = null!;

    public string ProcedureId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
