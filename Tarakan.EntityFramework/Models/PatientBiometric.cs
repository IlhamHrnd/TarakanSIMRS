using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientBiometric
{
    public string PatientId { get; set; }

    public string IndexF { get; set; }

    public string DataF { get; set; }

    public DateTime? CreatedDate { get; set; }
}
