using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientGenogram
{
    public string PatientId { get; set; } = null!;

    public byte[]? Genogram { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
