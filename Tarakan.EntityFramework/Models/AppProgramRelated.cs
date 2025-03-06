using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppProgramRelated
{
    public string ProgramId { get; set; }

    public string RelatedProgramId { get; set; }

    public string ReferenceId { get; set; }
}
