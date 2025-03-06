using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppProgramSignature
{
    public string UserId { get; set; }

    public string ProgramId { get; set; }

    public string Signature { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
