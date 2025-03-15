using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientBiometric
{
    public string PatientId { get; set; } = null!;

    public string IndexF { get; set; } = null!;

    public string DataF { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }
}
