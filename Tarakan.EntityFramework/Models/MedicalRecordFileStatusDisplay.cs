using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalRecordFileStatusDisplay
{
    public string Ip { get; set; }

    public string Code { get; set; }

    public int? CurrentPage { get; set; }
}
