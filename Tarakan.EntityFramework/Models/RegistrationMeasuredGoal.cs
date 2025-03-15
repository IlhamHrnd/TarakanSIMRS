using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationMeasuredGoal
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? SruserType { get; set; }

    public string? Problem { get; set; }

    public string? Planning { get; set; }

    public string? Goal { get; set; }

    public int? IterationQty { get; set; }

    public int? Qty { get; set; }

    public string? SrtimeType { get; set; }

    public bool? IsVoid { get; set; }
}
