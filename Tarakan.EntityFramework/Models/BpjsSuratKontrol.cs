using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsSuratKontrol
{
    public string GuarantorCardNo { get; set; } = null!;

    public string NoSuratKontrol { get; set; } = null!;

    public DateTime SuratKontrolDate { get; set; }

    public string? JsonData { get; set; }
}
