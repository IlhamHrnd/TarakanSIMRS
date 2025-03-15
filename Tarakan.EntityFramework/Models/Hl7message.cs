using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Hl7message
{
    public Guid MessageId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime MessageDateTime { get; set; }

    public string MessageFileName { get; set; } = null!;

    public string? SritemType { get; set; }

    public string? RefferenceNo { get; set; }

    public string? Remarks1 { get; set; }

    public string? Remarks2 { get; set; }
}
