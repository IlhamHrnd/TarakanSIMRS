using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingDiagnosaTemplateServiceUnit
{
    public int TemplateId { get; set; }

    public string ServiceUnitId { get; set; } = null!;
}
