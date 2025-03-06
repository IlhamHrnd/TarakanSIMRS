using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Appprogbak
{
    public string ProgramId { get; set; }

    public string ParentProgramId { get; set; }

    public string ProgramName { get; set; }

    public string ProgramType { get; set; }

    public string ApplicationId { get; set; }
}
