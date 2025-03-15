using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppProgramSignature
{
    public string UserId { get; set; } = null!;

    public string ProgramId { get; set; } = null!;

    public string Signature { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
