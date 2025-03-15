using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationPathwayItemExecution
{
    public string RegistrationNo { get; set; } = null!;

    public string PathwayId { get; set; } = null!;

    public int PathwayItemSeqNo { get; set; }

    public int DayNo { get; set; }

    public bool IsApprove { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
