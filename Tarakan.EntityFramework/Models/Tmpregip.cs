using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Tmpregip
{
    public DateOnly? Tanggal { get; set; }

    public string ServiceUnitName { get; set; }

    public string RegistrationNo { get; set; }

    public int? IsDischarge { get; set; }

    public DateOnly? DischargeDate { get; set; }

    public int? Total { get; set; }
}
